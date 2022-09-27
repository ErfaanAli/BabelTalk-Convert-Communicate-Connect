using Scribe_Factory_Core.Models;
using Scribe_Factory_Core.Repositories.Interfaces;
using Scribe_Factory_Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scribe_Factory_Core.Repositories
{
    public class ProjectManagementRepository : IProjectManagementRepository
    {
        ScribeFactoryContext scribeFactoryContext = null;
        public ProjectManagementRepository(ScribeFactoryContext scribeFactoryContext)
        {
            this.scribeFactoryContext = scribeFactoryContext;
        }

        public List<Project> GetProjects(UserLoginViewModel currentuser)
        {
            var Allprojects = scribeFactoryContext.Projects.Where(x => x.TenantId == currentuser.User.TenantId).ToList();
            return Allprojects;
        }
        public List<ProjectFiles> GetProjectFiles(int projectId)
        {
            var projectFiles = scribeFactoryContext.ProjectFiles.Where(x => x.ProjectId == projectId).ToList();
            return projectFiles;
        }
        public int SaveProject(string projectName,string projectType,long tenantId)
        {
            try
            {
                Project Newproject = new Project();
                Newproject.ProjectName = projectName;
                Newproject.ProjectType = projectType;
                Newproject.TenantId = tenantId;
                //add time of creation in future (need to update db)
                scribeFactoryContext.Projects.Add(Newproject);
                scribeFactoryContext.SaveChanges();
                return Newproject.Id;
            }
            catch
            {
                return -1;
            }
        }
    }
}
