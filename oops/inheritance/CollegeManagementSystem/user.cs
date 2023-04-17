using System;

namespace intern_task.oops.inheritance
{
    public class User
    {
        private string name ; 
        private string email ;
        private string address ;

        public string Name 
        {
            get { return name; }
            set { name = value ; }

        }
        public string Email
        {
            get { return email; }
            set { email = value ; }

        }
        
        public string Address 
        {
            get { return address ; }
            set { address = value ; }

        }
        
    }
}