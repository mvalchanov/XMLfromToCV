using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using XMLfromToCV.Models;

namespace XMLfromToCV.Controllers
{
    public class HomeController : Controller
    {

        private IHostingEnvironment _env;

        public HomeController(IHostingEnvironment env)
        {
            this._env = env;
        }

        /// <summary>
        /// Deserialize and load informationfrom current .xml file
        /// </summary>
        public IActionResult Index()
        {
            try
            {
                Person person = FindPersonDir("cv.xml");
                return View(person);
            }
            catch (Exception ex)
            {
                //Logger
                throw;
            }
        }

        

        /// <summary>
        /// Deserialize and load informationfrom new .xml file
        /// </summary>
        public IActionResult IndexEdited()
        {
            try
            {
                Person person = FindPersonDir("cv-Edited.xml");
                return View(person);
            }
            catch (Exception ex)
            {
                //Logger
                throw;
            }
        }
        /// <summary>
        /// Return person from edit form and create/re-write
        ///     .xml file
        /// </summary>
        /// <param name="person"> Person Information from edit form</param>
        /// <returns>
        /// View with edited information
        /// </returns>

        public IActionResult Edit(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", person);
            }

            string wwwroot = _env.WebRootPath;
            string projectFolder = "\\xmls\\";
            string parentDirName = string.Concat(wwwroot, projectFolder);
            string fileName = "cv-Edited.xml";

            
            TextWriter writer = new StreamWriter(parentDirName + fileName);
            XmlSerializer ser = new XmlSerializer(typeof(Person));

            //Start writing to the cv-Edited.xml and create if needs.
            ser.Serialize(writer, person);
            writer.Close();

            return RedirectToAction(nameof(IndexEdited));
        }

        /// <summary>
        /// Localize \xmls\ directory
        /// </summary>
        /// <param name="fileName"></param>
        private Person FindPersonDir(string fileName)
        {

            Person person;
            string wwwroot = _env.WebRootPath;
            string projectFolder = "\\xmls\\";
            string parentDirName = string.Concat(wwwroot, projectFolder);


            XmlSerializer des = new XmlSerializer(typeof(Person));
            using (XmlReader reader = XmlReader.Create(parentDirName + fileName))
            {
                person = (Person)des.Deserialize(reader);
            }

            return person;
        }
    }
}
