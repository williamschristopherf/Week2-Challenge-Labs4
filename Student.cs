namespace Week2_Challenge_Labs4
{
    internal class Student
    {
        public string Division { get; set; }
        public string RollNumber { get; set; }
        public string StudentName { get; set; }
        public double ChemistryGrade { get; set; }
        public double ComputerGrade { get; set; }
        public double Percent { get; set; }
        public double PhysicsGrade { get; set; }
        public double Total { get; set; }

        //Separate methods for Calculate total ,percent, and division to control when they are set. 
        public double CalculateTotal(double physicsGrade, double chemistryGrade, double computerGrade)
        {
            return physicsGrade + chemistryGrade + computerGrade;
        }

        public double CalculatePercent(double total)
        {
            return total / 300;
        }

        public void CalculateDivision()
        {
            switch (Percent)
            {
                case > .6:
                    Division = "Division 1";
                    break;
                case < .6 and > .45:
                    Division = "Division 2";
                    break;
                case < .45 and > .33:
                    Division = "Division 3";
                    break;
            }
        }
    }
}
