using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNSFC
{
    class Resources
    {
        public Resources()
        {

        }

        public Resources(Note note)
        {
            if (note == null)
            {
                return;
            }

            NodeID = note.nodeId;
            object value;
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
            if (note.fields.TryGetValue("Copyright", out value))
            {
                Copyright = (String)value;
            }
            if (note.fields.TryGetValue("Form", out value))
            {
                Form = (String)value;
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
        }

        public string NodeID;
        public string AllowedToRead;
        public string AllowedToEdit;
        public string Creator;
        public string Status;
        public DateTime CreationDatetime;
        public string Copyright;
        public string Form;
        public string FullUpdateHistory;
        public string ActionUpdateHistory;
        public string UserUpdateHistory;
        public string CommentUpdateHistory;
        public string DatetimeUpdateHistory;
        public string path;
    }
}
