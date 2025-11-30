using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.domain.Entities;

namespace UserApp.application.DTOs.Companies
{
    public class CompanyDto
    {

        public string Name { get; set; }


        public static CompanyDto FromEntity(Company c)
        {
            return new CompanyDto
            {

                Name = c.Name

            };
        }
    }
}
