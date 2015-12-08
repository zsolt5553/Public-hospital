using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class ServicesPage : System.Web.UI.Page
    {
        List<DoctorServiceRef.Doctor> sortedDoctors;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var client = new DoctorServiceRef.DoctorServiceClient();
                List<DoctorServiceRef.Doctor> doctors = client.GetAllDoctors().ToList();
                populateTreeView(doctors);
            }
                 
        }



        private void populateTreeView(List<DoctorServiceRef.Doctor> doctors)
        {
            sortedDoctors = doctors.OrderBy(doc => doc.specialty).ToList();
            var topNode = new TreeNode("Services");
            TreeView1.Nodes.Add(topNode);
            string currentSpecialty = sortedDoctors.First().specialty;
            var treeNodes = new List<TreeNode>();
            var childNodes = new List<TreeNode>();
            foreach (DoctorServiceRef.Doctor doc in sortedDoctors)
            {
                if (currentSpecialty == doc.specialty)
                    childNodes.Add(new TreeNode(doc.firstName + " " + doc.lastName));
                else
                {
                    if (childNodes.Count > 0)
                    {
                        TreeNode newNode = new TreeNode(currentSpecialty);
                        foreach (TreeNode node in childNodes)
                        {
                            newNode.ChildNodes.Add(node);
                        }
                        treeNodes.Add(newNode);
                        childNodes = new List<TreeNode>();
                    }
                    childNodes.Add(new TreeNode(doc.firstName + " " + doc.lastName));
                    currentSpecialty = doc.specialty;
                }
            }
            if (childNodes.Count > 0)
            {

                TreeNode newNode = new TreeNode(currentSpecialty);
                foreach (TreeNode node in childNodes)
                {
                    newNode.ChildNodes.Add(node);
                }
                treeNodes.Add(newNode);
            }
            foreach (TreeNode node in treeNodes)
            {
                TreeView1.Nodes.Add(node);
            }
            TreeView1.CollapseAll();
            TreeView1.DataBind();
        }
    }
}