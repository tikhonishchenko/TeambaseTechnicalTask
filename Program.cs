using TeambaseTechnicalTask;

PremiumCalculator premiumCalculator = new PremiumCalculator(new DateTime(2021, 3, 1), 25, 'f', 'd');

Console.WriteLine("A woman of 25 years that joined the company on 2021.03.01 prorated by days"+premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 7, 12), 12, 'f', 'm');

Console.WriteLine("A woman of 12 years that joined the company on 2021.07.12 prorated by months" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 5, 23), 44, 'm', 'd');

Console.WriteLine("A man of 44 years that joined the company on 2021.05.23 prorated by days" + premiumCalculator.CalculateProratedPremium());


premiumCalculator = new PremiumCalculator(new DateTime(2023, 2, 24), 20, 'f', 'd');

Console.WriteLine("A woman of 20 years that joined the company on 2023.02.24 prorated by days" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2023, 2, 24), 29, 'f', 'd');

Console.WriteLine("A woman of 29 years that joined the company on 2023.02.24 prorated by days" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 1, 28), 31, 'm', 'm');

Console.WriteLine("A man of 31 years that joined the company on 2021.01.28 prorated by months" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 4, 16), 18, 'm', 'd');

Console.WriteLine("A man of 18 years that joined the company on 2021.04.16 prorated by days" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 4, 16), 18, 'f', 'd');

Console.WriteLine("A woman of 18 years that joined the company on 2021.04.16 prorated by days" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 4, 16), 12, 'm', 'd');

Console.WriteLine("A man of 12 years that joined the company on 2021.04.16 prorated by days" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 4, 16), 12, 'f', 'd');

Console.WriteLine("A woman of 12 years that joined the company on 2021.04.16 prorated by days" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 4, 16), 19, 'm', 'd');

Console.WriteLine("A man of 19 years that joined the company on 2021.04.16 prorated by days" + premiumCalculator.CalculateProratedPremium());

premiumCalculator = new PremiumCalculator(new DateTime(2021, 4, 16), 19, 'f', 'd');

Console.WriteLine("A woman of 19 years that joined the company on 2021.04.16 prorated by days" + premiumCalculator.CalculateProratedPremium());
