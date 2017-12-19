using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Domino;
using lotus;
using Newtonsoft.Json;

namespace ReadNSFC
{
    class ReadDomino
    {
        public static void Main()
        {
            string path =  Settings.Default.path;
            string query = Settings.Default.query;
            string type = Settings.Default.type;
            ReadDomino.parseFile(path,query,type);
        }

        public static void parseFile(string path, string searchQuery, string type)
        {
            Domino.NotesSession session = null;
            session = new Domino.NotesSession();
            session.Initialize("");
            List<ContentDetail> lstContent = new List<ContentDetail>();
            List<Resources> lstResource = new List<Resources>();

            Domino.NotesDatabase db = session.GetDatabase("", path, false);

            Domino.NotesDocumentCollection col = db.Search(searchQuery, null, 0);
            for (int i = 0; i < col.Count; i++)
            {
                NotesDocument nd = col.GetNthDocument(i);
                Note note = new Note();
                note.nodeId = nd.NoteID;
                note.fields = new Dictionary<string, object>();
                List<string> ebpath = null;
                foreach (NotesItem item in nd.Items)
                {
                    if (item.Name == "$FILE")
                    {
                        NotesItem file = nd.GetFirstItem("$File");
                        string fileName = ((object[])item.Values)[0].ToString();
                        NotesEmbeddedObject attachfile = (NotesEmbeddedObject)nd.GetAttachment(fileName);
                        if (attachfile != null)
                        {
                            string p = Settings.Default.saveDirectory + nd.NoteID + "\\" + fileName;
                            System.IO.Directory.CreateDirectory(Settings.Default.saveDirectory + nd.NoteID);
                            if (ebpath == null)
                            {
                                ebpath = new List<string>();
                            }
                            ebpath.Add(p);
                            try
                            {
                                attachfile.ExtractFile(p);
                            } catch(Exception en)
                            {
                                Console.WriteLine(en.Message);
                            }
                        }

                    }
                    else
                    {
                        try
                        {
                            if (item.type == IT_TYPE.RICHTEXT)
                            {
                                note.fields.Add(item.Name, item.Values);
                            } else
                            {
                                note.fields.Add(item.Name, item.Values[0]);
                            }
                        } catch (Exception en)
                        {
                            Console.WriteLine(en.Message);
                        }
                    }
                }

                if (type == "resource"){
                    Resources rs = new Resources(note);
                    if(ebpath != null && ebpath.Count > 0)
                    {
                        foreach(string p in ebpath)
                        {
                            rs.path=rs.path+ p+";";
                        }

                    }
                    lstResource.Add(rs);

                } else
                {
                    ContentDetail ct = new ContentDetail(note);
                    lstContent.Add(ct);
                }


            }
            if (lstContent != null && lstContent.Count > 0)
            {
                string json = JsonConvert.SerializeObject(lstContent);
                //write string to file
                System.IO.File.WriteAllText(@Settings.Default.saveDirectory+"cms.txt", json);
            }

            if(lstResource != null && lstResource.Count > 0)
            {
                string json = JsonConvert.SerializeObject(lstResource);
                //write string to file
                System.IO.File.WriteAllText(@Settings.Default.saveDirectory+"resource.txt", json);

            }


        }
    }
}
