namespace Models
{
	public class DatabaseContextInitializer :
		System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
	{
		public DatabaseContextInitializer() : base()
		{
		}

		protected override void Seed(DatabaseContext databaseContext)
		{
			for (int index = 1; index <= 1013; index++)
			{
				string countryName = $"Country { index }";

				Country country =
					new Country()
					{
						Name = countryName,
					};

				databaseContext.Countries.Add(country);
			}

			// Optional
			databaseContext.SaveChanges();
		}
	}
}
