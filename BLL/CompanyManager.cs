using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    //public class CompanyManager : Repository<CompanyManager, LinkedInContext>
    //{
    //    public CompanyManager(LinkedInContext context) : base(context)
    //    {
    //    }
    //    public  List<Company> ViewAllCompanies()
    //    {
    //        return AppManager.linkedInContext.Companies.ToList();
    //    }
    //    public  void AddCompany(string name, string address,
    //        string type, string desc)
    //    {
    //        Company company = new Company();
    //        company.Name = name;
    //        company.Address = address;
    //        company.Type = type;
    //        company.Description = desc;
    //        AppManager.linkedInContext.Companies.Add(company);
    //        AppManager.linkedInContext.SaveChanges();
    //    }
    //    public  void RemoveCompany(int company_id)
    //    {
    //        Company companyToDelete = AppManager.linkedInContext.Companies
    //             .Select(p => p).Where(p => p.Id == company_id).FirstOrDefault();
    //        AppManager.linkedInContext.Companies.Remove(companyToDelete);
    //        AppManager.linkedInContext.SaveChanges();
    //    }
    //}
}
