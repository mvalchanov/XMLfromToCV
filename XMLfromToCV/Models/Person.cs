using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace XMLfromToCV.Models
{

    [XmlRoot("Person")]
    public class Person
    {
        //Personal Information
        [XmlElement("FullName")]
        [Required(ErrorMessage = @"The ""Full Name"" field is required.")]
        public string FullName { get; set; }
        [XmlElement("Address")]
        [Required(ErrorMessage = @"The ""Address"" field is required.")]
        public string Address { get; set; }
        [XmlElement("Phone")]
        [Required(ErrorMessage = @"The ""Phone No."" field is required.")]
        public string Phone { get; set; }

        //See more about email regex at https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        //Regex editor https://regex101.com/
        [RegularExpression((@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"), ErrorMessage = "Invalid e-mail address!")]
        [Required(ErrorMessage = @"The ""E-mail"" field is required.")]
        [XmlElement("E-mail")]
        public string Email { get; set; }
        [XmlElement("Nationality")]
        public string Nationality { get; set; }
        [XmlElement("DateOfBiirth")]
        [Required(ErrorMessage = @"The ""Birth date"" field is required.")]
        public string DateOfBirth { get; set; }

        //Working experience
        [XmlAttribute("WorkingExperience")]
        public string WorkExp { get; set; }
        [XmlElement("WorkDateFrom")]
        public string WorkDateFrom { get; set; }
        [XmlElement("WorkDateTo")]
        public string WorkDateTo { get; set; }
        [XmlElement("Employer")]
        public string Employer { get; set; }
        [XmlElement("WorkOccupation")]
        public string WorkOccupation { get; set; }
        [XmlElement("WorkMainActAndResp")]
        public string WorkMainActAndResp { get; set; }

        //Education
        [XmlElement("UniversityName")]
        public string UniversityName { get; set; }
        [XmlElement("EdDateFrom")]
        public string EdDateFrom { get; set; }
        [XmlElement("EdDateTo")]
        public string EdDateTo { get; set; }
        [XmlElement("EdOrganization")]
        public string EdOrganization { get; set; }
        [XmlElement("EdQualification")]
        public string EdQualification { get; set; }
        [XmlElement("EdOccupation")]
        public string EdOccupation { get; set; }

        //Personal Skills and competences
        [XmlElement("MotherLanguage")]
        public string MotherLanguage { get; set; }
        [XmlElement("Language")]
        public string Language { get; set; }
        [XmlElement("ReadingSkills")]
        public string ReadingSkills { get; set; }
        [XmlElement("WritingSkills")]
        public string WritingSkills { get; set; }
        [XmlElement("VerbalSkills")]
        public string VerbalSkills { get; set; }

        //Social skills
        [XmlElement("SocSkill1")]
        public string SocSkill1 { get; set; }
        [XmlElement("SocSkill2")]
        public string SocSkill2 { get; set; }
        [XmlElement("SocSkill3")]
        public string SocSkill3 { get; set; }
        [XmlElement("SocSkill4")]
        public string SocSkill4 { get; set; }
        [XmlElement("SocSkill5")]
        public string SocSkill5 { get; set; }
        [XmlElement("SocSkill6")]
        public string SocSkill6 { get; set; }

        //Organization skills
        [XmlElement("OrgSkill")]
        public string OrgSkill { get; set; }
        [XmlElement("OrgSkill1")]
        public string OrgSkill1 { get; set; }
        [XmlElement("OrgSkill2")]
        public string OrgSkill2 { get; set; }
        [XmlElement("OrgSkill3")]
        public string OrgSkill3 { get; set; }

        //Working skills
        [XmlElement("WorkSkill")]
        public string WorkSkill { get; set; }
        [XmlElement("WorkSkill1")]
        public string WorkSkill1 { get; set; }
        [XmlElement("WorkSkill2")]
        public string WorkSkill2 { get; set; }
        [XmlElement("WorkSkill3")]
        public string WorkSkill3 { get; set; }
        [XmlElement("WorkSkill4")]
        public string WorkSkill4 { get; set; }

        //Basic working skills
        [XmlElement("BasicSkill")]
        public string BasicSkill { get; set; }
        [XmlElement("BasicSkill1")]
        public string BasicSkill1 { get; set; }
        [XmlElement("BasicSkill2")]
        public string BasicSkill2 { get; set; }
        [XmlElement("BasicSkill3")]
        public string BasicSkill3 { get; set; }

        //Artistic skills
        [XmlElement("ArtSkill")]
        public string ArtSkill { get; set; }
        [XmlElement("ArtSkill1")]
        public string ArtSkill1 { get; set; }

        //Additional information
        [XmlElement("AdditionalInformation")]
        public string AdditionalInformation { get; set; }
    }
}
