namespace ChamadaFiap.Dto
{
    public class ReadClassDto
    {
        public string Name { get; set; }
        public virtual ReadTeamDto Team { get; set; }
        public virtual ReadSubjectDto Subject { get; set; }
    }
}
