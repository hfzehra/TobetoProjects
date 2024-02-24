using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonelLoanManager personelLoanManager = new PersonelLoanManager();
            ICreditManager personelLoanManager = new PersonelLoanManager();
            //personelLoanManager.Calculate();

            //VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();   
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            //HousingLoanManager housingLoanManager = new HousingLoanManager();
            ICreditManager housingLoanManager = new HousingLoanManager();
            //housingLoanManager.Calculate();

            ILoggerService databaseloggerService=new DatabaseLoggerService();
            ILoggerService fileLoggerService= new FileLoggerService();

            AppCreditManager appCreditManager = new AppCreditManager();
            appCreditManager.BasvuruYap(vehicleLoanManager,fileLoggerService);


            List<ICreditManager> credits = new List<ICreditManager>()
            {
                personelLoanManager,
                vehicleLoanManager,
                housingLoanManager
            };

            //appCreditManager.KrediOnBilgilendirmesiYap(credits);

        }
    }
}