namespace Methods
{
    using System;

    public class Student
    {
        #region Fields

        private string firstName;
        private string lastName;

        #endregion

        #region Properties

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You must enter your first name!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("You must enter your last name!");
                }

                this.lastName = value;
            }
        }

        public string OtherInfo { get; set; }
        #endregion

        #region Methods
        public bool IsOlderThanOther(Student other)
        {
            try
            {
                DateTime firstDate = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
                DateTime secondDate = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
                return firstDate > secondDate;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return false;
        }
        #endregion
    }
}
