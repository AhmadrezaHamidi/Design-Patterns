using ReportBuilder.Src.Builders;

namespace ReportBuilder.Src.Directores;

public class ProfitReportGenerator
{
    //Director
    private readonly IRepostBuilder repostBuilder;

    public ProfitReportGenerator(IRepostBuilder repostBuilder)
    {
        this.repostBuilder = repostBuilder;
    }


    public void Pars(string filePath)
    {
        //Load DataFromdb 
        var datas = GenerateMNockDatas.GEtDats();
        repostBuilder.AddTitle("title");
        foreach (var item in datas)
        {
            repostBuilder.AddDescription(item.ToString());
        }
    }
}
public static class GenerateMNockDatas{
    
public static List<DatasStructer> GEtDats()
    {
        var res = new List<DatasStructer>();


        for (int i = 0; i < 100; i++)
        {
            res.Add(new DatasStructer(Guid.NewGuid()));
        }
        return res;
    }

}

public class DatasStructer
{
    public DatasStructer(Guid id)
    {
        this.id = id;
    }

    public Guid id { get; set; }
}