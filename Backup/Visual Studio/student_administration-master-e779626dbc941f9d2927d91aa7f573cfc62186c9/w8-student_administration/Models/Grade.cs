using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdministration.Models
{
    public class Grade
    {
        public readonly decimal Analysis;
        public readonly decimal Design;
        public readonly decimal Code;

        public Grade(decimal Analysis, decimal Design, decimal Code)
        {
            this.Analysis = Analysis;
            this.Design = Design;
            this.Code = Code;
        }

        void InvalidGradeException()
        {

        }
    }

}
