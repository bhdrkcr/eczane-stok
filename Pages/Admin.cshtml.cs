using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebProjeleri2022.Models;
using WebProjeleri2022.Services;

namespace WebProjeleri2022.Pages
{
    public class AdminModel : PageModel
    {
        public JsonProjectService jsonProjectService;
        public AdminModel(JsonProjectService JsonProjectService)
        {
            jsonProjectService = JsonProjectService;
        }

        [BindProperty]
        public ProjectModel proje { get; set; }

        [BindProperty]
        public string SearchId { get; set; }

        [BindProperty]
        public string Memberlist { get; set; }



        public void OnGet()
        {
        }

        public IActionResult OnPostForm()
        {
            proje.members = stringtolist(Memberlist);
            if (proje.id == 0)
                jsonProjectService.AddProject(proje);
            else
                jsonProjectService.UpdateProject(proje);

            return RedirectToPage("/Index", new { Status = "Success" });

        }

        public void OnPostClear()
        {
            proje = null;
            SearchId = "";
        }

        public void OnPostGetProjectbyID()
        {
            proje = jsonProjectService.GetProjectbyID(Convert.ToInt32(SearchId));
            if (proje != null)
                Memberlist = listtostring(proje.members);
        }

        public IActionResult OnPostDeletebyID()
        {
            bool status = jsonProjectService.DeleteProject(proje);

            if (status)
                return RedirectToPage("/Index", new { Status = "Success" });
            else
                return RedirectToPage("/Index", new { Status = "Error" });

        }

        public string[] stringtolist(string memberlist)
        {

            if (!String.IsNullOrEmpty(memberlist))
                return memberlist.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            else
                return Array.Empty<string>();

        }

        public string listtostring(string[] memberlist)
        {
            if (memberlist.Length == 0)
                return String.Join(Environment.NewLine, memberlist);
            else
                return "";


        }
    }
}
