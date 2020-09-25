using System.Linq;

namespace LEARNING_ENTITY_FRAMEWORK
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		protected int PageSize { get; set; }

		protected int PageIndex { get; set; }

		protected Models.DatabaseContext MyDatabaseContext { get; set; }

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			PageSize = 10;
			PageIndex = 0;

			try
			{
				MyDatabaseContext =
					new Models.DatabaseContext();

				DisplayCountries();
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
			finally
			{
			}
		}

		private void FirstButton_Click(object sender, System.EventArgs e)
		{
			PageIndex = 0;

			DisplayCountries();
		}

		private void PreviousButton_Click(object sender, System.EventArgs e)
		{
			if (PageIndex > 0)
			{
				PageIndex--;

				DisplayCountries();
			}
		}

		private void NextButton_Click(object sender, System.EventArgs e)
		{
			if (PageIndex < GetLastPageIndex())
			{
				PageIndex++;

				DisplayCountries();
			}
		}

		private void LastButton_Click(object sender, System.EventArgs e)
		{
			PageIndex = GetLastPageIndex();

			DisplayCountries();
		}

		private void DisplayCountries()
		{
			pageIndexLabel.Text = (PageIndex + 1).ToString("#,##0");
			pageCountLabel.Text = (GetLastPageIndex() + 1).ToString("#,##0");

			// در زمان استفاده از
			// Skip و Take
			// استفاده از دستور
			// OrderBy
			// الزامی است
			var countries =
				MyDatabaseContext.Countries
				//.Where
				.OrderBy(current => current.Name)
				.Skip(PageIndex * PageSize)
				.Take(PageSize)
				.ToList()
				;

			countriesListBox.ValueMember = nameof(Models.Country.Id);
			countriesListBox.DisplayMember = nameof(Models.Country.Name);

			countriesListBox.DataSource = countries;
		}

		private int GetCountryCount()
		{
			int count =
				MyDatabaseContext.Countries
				.Count();

			return count;
		}

		private int GetLastPageIndex()
		{
			int count =
				GetCountryCount();

			if (count % PageSize == 0)
			{
				return (count / PageSize) - 1;
			}
			else
			{
				return count / PageSize;
			}
		}

		private void MainForm_FormClosed
			(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			if (MyDatabaseContext != null)
			{
				MyDatabaseContext.Dispose();
				MyDatabaseContext = null;
			}
		}
	}
}
