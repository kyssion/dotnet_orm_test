using System.Text;
using efcore_test.modules;
using Microsoft.EntityFrameworkCore;
using Models;
using Npgsql;
using SqlSugar;

namespace efcore_test;

public class Program
{
    public static void Main(string[] args)
    {
        // //创建数据库对象 (用法和EF Dappper一样通过new保证线程安全)
        // SqlSugarClient Db = new SqlSugarClient(new ConnectionConfig()
        //     {
        //         ConnectionString = "Host=39.100.86.193;Username=postgres;Password=Javarustc++11.;Database=k_media_platform;Pooling=true;;Maximum Pool Size=20",
        //         DbType = DbType.PostgreSQL,
        //         IsAutoCloseConnection = true
        //     },
        //     db => {
        //     });
        var builder = WebApplication.CreateSlimBuilder(args);
        builder.Services.AddEndpointsApiExplorer();
        var app = builder.Build();
        var dataSource = NpgsqlDataSource.Create("Host=39.100.86.193;Username=postgres;Password=Javarustc++11.;Database=k_media_platform;Pooling=true;Maximum Pool Size=20;");       
        app.MapGet("/",async () =>
        {
            await using var command = dataSource.CreateCommand($"SELECT * FROM media_resources limit 10000");
            await using var reader = await command.ExecuteReaderAsync();
            StringBuilder sb = new StringBuilder();
            while (await reader.ReadAsync())
            {
                sb.Append(reader.GetInt64(0)).Append("\n");
            }
            return sb.ToString();
        
            // var context = new KMediaPlatformContext();
            // var ans =await  context.MediaResources.ToListAsync();
            // return ans[0].Id.ToString();
            // var item = Db.CopyNew();
            // var arr = await item.Queryable<media_resources>().ToListAsync();
            // return arr[0].id.ToString();
        });
        app.Run();
    }
}