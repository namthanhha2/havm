using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNSFC
{
    class ContentDetail
    {
        public ContentDetail()
        {

        }

        public ContentDetail(Note note)
        {
            if (note == null)
            {
                return;
            }

            NodeID = note.nodeId;
            object value;
            if (note.fields.TryGetValue("Content", out value))
            {
                Content = Convert.ToString(value);
            }
            if (note.fields.TryGetValue("AllowedToRead", out value))
            {
                AllowedToRead = (String)value;
            }
            if (note.fields.TryGetValue("AllowedToEdit", out value))
            {
                AllowedToEdit = (String)value;
            }
            if (note.fields.TryGetValue("Creator", out value))
            {
                Creator = (String)value;
            }
            if (note.fields.TryGetValue("Status", out value))
            {
                Status = (String)value;
            }
            if (note.fields.TryGetValue("CreationDatetime", out value))
            {
                CreationDatetime = (DateTime)value;
            }
            if (note.fields.TryGetValue("StaffCanEdit", out value))
            {
                StaffCanEdit = (String)value;
            }
            if (note.fields.TryGetValue("FullUpdateHistory", out value))
            {
                FullUpdateHistory = (String)value;
            }
            if (note.fields.TryGetValue("ActionUpdateHistory", out value))
            {
                ActionUpdateHistory = (String)value;
            }
            if (note.fields.TryGetValue("UserUpdateHistory", out value))
            {
                UserUpdateHistory = (String)value;
            }
            if (note.fields.TryGetValue("CommentUpdateHistory", out value))
            {
                CommentUpdateHistory = (String)value;
            }
            if (note.fields.TryGetValue("DatetimeUpdateHistory", out value))
            {
                DatetimeUpdateHistory = (String)value;
            }
            //-----------------------------------
            if (note.fields.TryGetValue("Language", out value))
            {
                Language = (String)value;
            }
            if (note.fields.TryGetValue("IsDone", out value))
            {
                IsDone = (String)value;
            }
            if (note.fields.TryGetValue("Index", out value))
            {
                try
                {
                    Index = Convert.ToInt32(value);
                } catch (Exception en)
                {
                    Console.WriteLine(en.Message);
                }
            }
            if (note.fields.TryGetValue("Parent_Title", out value))
            {
                Parent_Title = (String)value;
            }
            if (note.fields.TryGetValue("Title", out value))
            {
                Title = (String)value;
            }
            if (note.fields.TryGetValue("Description", out value))
            {
                Description = (String)value;
            }
            if (note.fields.TryGetValue("ShortContent", out value))
            {
                ShortContent = (String)value;
            }
            if (note.fields.TryGetValue("Display", out value))
            {
                Display = (String)value;
            }
            if (note.fields.TryGetValue("Function", out value))
            {
                Function = (String)value;
            }
            if (note.fields.TryGetValue("OpenURL", out value))
            {
                OpenURL = (String)value;
            }
            if (note.fields.TryGetValue("Feature", out value))
            {
                Feature = (String)value;
            }
            //------------------------------------
            if(note.fields.TryGetValue("SynID", out value)){
                SynID = (String)value;
            }
            if (note.fields.TryGetValue("Parent_SynID", out value))
            {
                Parent_SynID = (String)value;
            }
            if (note.fields.TryGetValue("IsHomePage", out value))
            {
                IsHomePage = (String)value;
            }
            if (note.fields.TryGetValue("hasChildrenDocs", out value))
            {
                hasChildrenDocs = (String)value;
            }
            if (note.fields.TryGetValue("Copyright", out value))
            {
                Copyright = (String)value;
            }
            if (note.fields.TryGetValue("ClientName", out value))
            {
                ClientName = (String)value;
            }
            if (note.fields.TryGetValue("Form", out value))
            {
                Form = (String)value;
            }
            if (note.fields.TryGetValue("ANCESTORTITLE", out value))
            {
                ANCESTORTITLE = (String)value;
            }
            if (note.fields.TryGetValue("ANCESTORUNID", out value))
            {
                ANCESTORUNID = (String)value;
            }
            if (note.fields.TryGetValue("ResourceFile", out value))
            {
                ResourceFile = (String)value;
            }
        }

        public string NodeID;
        public string Content;
        public string AllowedToRead;
        public string AllowedToEdit;
        public string Creator;
        public string Status;
        public DateTime CreationDatetime;
        public string StaffCanEdit;
        public string FullUpdateHistory;
        public string ActionUpdateHistory;
        public string UserUpdateHistory;
        public string CommentUpdateHistory;
        public string DatetimeUpdateHistory;
        public string Language;
        public string IsDone;
        public long Index;
        public string Parent_Title;
        public string Title;
        public string ShortContent;
        public string Description;
        public string Display;
        public string Function;
        public string OpenURL;
        public string Feature;
        public string SynID;
        public string Parent_SynID;
        public string IsHomePage;
        public string hasChildrenDocs;
        public string Copyright;
        public string ClientName;
        public string Form;
        public string ANCESTORTITLE;
        public string ANCESTORUNID;
        public string ResourceFile;
    }
}
