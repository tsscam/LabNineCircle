using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNine
{
    class CircleClass
    {
        private double radius;
        private double area;
        private double circumference;
        
        public CircleClass (double radiusInput)
        {
            radius = radiusInput;
            circumference = GetCircumference();

         }

        public string FormattedNumber1
        {
            get
            {
                return FormattedNumber1;
            }

            set
            {
                FormattedNumber = value;
            }
        }

        public string FormattedArea1
        {
           
        }

        public int Radius1
        {
            get
            {
                return Radius;
            }

            set
            {
                Radius = value;
            }
        }

        public string FormatedCircumference1
        {
            get
            {
                return FormatedCircumference;
            }

            set
            {
                FormatedCircumference = value;
            }
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
                 
            }
        }
    }
