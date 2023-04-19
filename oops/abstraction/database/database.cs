using System ;
 
 namespace intern_task.oops
 {
    class Database
    {
        static void Main(string[] args)
        {

            //creating object for the MySqlDatAccessLayer

            MySqlDataAccessLayer mySqlDataAccessLayer = new MySqlDataAccessLayer();
            mySqlDataAccessLayer.nonAbstractMethod();
            mySqlDataAccessLayer.Insert("Vignesh");
            mySqlDataAccessLayer.Insert("Steve");
            mySqlDataAccessLayer.Insert("Mitchell");
            mySqlDataAccessLayer.Insert("Mike");

            mySqlDataAccessLayer.DisplayData();

            mySqlDataAccessLayer.Update("Vignesh","Kevin");

            mySqlDataAccessLayer.Delete("Mike");

            mySqlDataAccessLayer.DisplayData();

             //creating object for the OracleDatAccessLayer

            OracleDataAccessLayer oracleDataAccessLayer = new OracleDataAccessLayer();

            oracleDataAccessLayer.Insert("David");
            oracleDataAccessLayer.Insert("Green");
            oracleDataAccessLayer.Insert("Maxi");
            oracleDataAccessLayer.Insert("Tim");

            oracleDataAccessLayer.Delete("Tim");

            oracleDataAccessLayer.DisplayData();


        }
    }
 }