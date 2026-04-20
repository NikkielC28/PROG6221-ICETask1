using System;
using System.Collections.Generic;
using System.Text;

namespace ICETask1
{
    public class Course
    {
        private int grade;

        // Property with validation
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Grade must be between 0 and 100.");
                }
            }
        }

        // Read-only property
        public bool IsPass
        {
            get { return grade >= 50; }
        }
    }
}
