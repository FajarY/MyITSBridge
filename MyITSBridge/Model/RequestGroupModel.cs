namespace MyITSBridge.Models
{
    public class RequestGroupModel : Model
    {
        private static List<RequestGroup> requestGroups = new List<RequestGroup>();
        public override void Initialize()
        {
            requestGroups.Add(new RequestGroup()
            {
                id = "RG001",
                name = "Surat Tugas Informatika",
                staffs = new List<string>()
                {
                    "aryshiddiqi@its.ac.id"
                },
                inputTemplates = new List<RequestTemplate>()
                {
                    new RequestTemplate()
                    {
                        name="Bukti Kepersertaan Lomba",
                        type=RequestTemplateType.PDF,
                        description="Bukti kepersertaan dalam bentuk pendaftaran atau format lainnya"
                    }
                }
            });
            requestGroups.Add(new RequestGroup()
            {
                id = "RG002",
                name = "Keuangan Ditmawa",
                staffs = new List<string>()
                {
                    "bintangnuralamsyah@its.ac.id",
                    "aryshiddiqi@its.ac.id"
                },
                inputTemplates = new List<RequestTemplate>()
                {
                    new RequestTemplate()
                    {
                        name="Proposal Keuangan",
                        type=RequestTemplateType.PDF,
                        description="Permintaan keuangan dalam bentuk proposal yang formal"
                    },
                    new RequestTemplate()
                    {
                        name="Dokumen Bukti Informasi Sebenarnya",
                        type=RequestTemplateType.PDF,
                        description="Pembuatan bukti bahwa dokumen yang diberikan dibuat dengan sebenar benarnya"
                    }
                }
            });
        }
        public static List<Tuple<string, string>> GetRequestGroupIDAndTypes()
        {
            List<Tuple<string, string>> list = new List<Tuple<string, string>>();
            foreach (RequestGroup group in requestGroups)
            {
                list.Add(new Tuple<string, string>(group.id, group.name));
            }

            return list;
        }
    }
}