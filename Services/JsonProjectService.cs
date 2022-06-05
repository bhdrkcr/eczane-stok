using System.Text.Json;
using WebProjeleri2022.Models;

namespace WebProjeleri2022.Services
{
    public class JsonProjectService
    {

        public JsonProjectService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment;

        public string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "projects.json"); }

        }


        public List<ProjectModel> GetProjects()
        {
            using var json = File.OpenText(JsonFileName);

            //return JsonSerializer.Deserialize<List<ProjectModel>>(json.Re());

            return JsonSerializer.Deserialize<ProjectModel[]>(json.ReadToEnd()).ToList();

        }

        public void AddProject(ProjectModel newproject)
        {
            List<ProjectModel> projects = GetProjects();
            newproject.id = projects.Max(x=> x.id) + 1;

            projects.Add(newproject);

            using var json = File.OpenWrite(JsonFileName);
            Utf8JsonWriter jsonwriter = new Utf8JsonWriter(json, new JsonWriterOptions { Indented = true });
            JsonSerializer.Serialize<List<ProjectModel>>(jsonwriter, projects);
        }

        public ProjectModel GetProjectbyID(int Id)
        {
            List<ProjectModel> projects = GetProjects();
            return projects.FirstOrDefault( x => x.id == Id);
        }


        public void UpdateProject(ProjectModel newproject)
        {
            List<ProjectModel> projects = GetProjects();

            ProjectModel query = projects.FirstOrDefault(x => x.id == newproject.id);
            if (query != null)
            {
                projects[projects.FindIndex(x => x.id == newproject.id)] = newproject;
                JsonWriter(projects, true);
            }

            //cozum c (Mertcan arkadasimizin onerisi, veriyi ekleyip ardından eskisini siliyoruz)
            //ProjectModel query = projects.FirstOrDefault(x => x.id == newproject.id);
            //projects.Insert(query.id, newproject);
            //projects.Remove(query);
            //JsonWriter(projects, true);

            //cozum b (dersten sonra Can arkadasimiz onerdi,
            //bana yine cok mantikli gelmedi arkadaslar, daha guzelini yapabiliriz :)
            //ProjectModel query = projects.FirstOrDefault(x => x.id == newproject.id);
            //query.id = newproject.id;
            //query.description = newproject.description;
            //query.url = newproject.url;
            //query.name = newproject.name;
            //JsonWriter(projects, true);

            //cozum a
            //int sayac = 0;
            //bool status = false;

            //foreach (var item in projects)
            //{
            //    if (item.id == newproject.id)
            //    {
            //        status = true;
            //        projects[sayac] = newproject;
            //        break;
            //    }

            //    sayac++;
            //}

            //if (status)
            //    JsonWriter(projects, true);

        }

        public bool DeleteProject(ProjectModel newproject)
        {
            List<ProjectModel> projects = GetProjects();
            ProjectModel query = projects.FirstOrDefault(x => x.id == newproject.id);
            if (query != null)
            {
                projects.Remove(query);
                JsonWriter(projects, true);
                return true;
            }
            else
                return false;

        }




        public void JsonWriter(List<ProjectModel> projects, bool status)
        {
            FileStream json;

            if(status)
                json = File.Create(JsonFileName);
            else
                json = File.OpenWrite(JsonFileName);

            Utf8JsonWriter jsonwriter = new Utf8JsonWriter(json, new JsonWriterOptions { Indented = true });
            JsonSerializer.Serialize<List<ProjectModel>>(jsonwriter, projects);
            json.Close();
        }



    }
}

