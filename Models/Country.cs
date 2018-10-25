namespace Models
{
	public class Country : BaseEntity
	{
		#region Configuration
		public class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Country>
		{
			public Configuration() : base()
			{
			}
		}
		#endregion /Configuration

		public Country() : base()
		{
		}

		// **********
		public string Name { get; set; }
		// **********
	}
}
