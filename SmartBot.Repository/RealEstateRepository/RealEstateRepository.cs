using Dapper;


namespace NhaDat24h.Repository.Repositories
{
    //public class RealEstateRepository
    //{
    //    public static List<RealEstateDto> GetListRE(int idctv, int pageIndex, int pageSize)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@idctv", idctv, System.Data.DbType.Int32);
    //        p.Add("@pageIndex", pageIndex, System.Data.DbType.Int32);
    //        p.Add("@pageSize", pageSize, System.Data.DbType.Int32);

    //        return DapperExtensions.QueryDapperStoreProc<RealEstateDto>(Procedures.sq_GetListRE, p).ToList();
    //    }
    //    public static List<RealEstateDto> GetMultiRE(List<int>? listIdRE, int pageIndex, int pageSize)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@idRE", listIdRE == null ? null : string.Join(",", listIdRE), System.Data.DbType.String);
    //        p.Add("@pageIndex", pageIndex, System.Data.DbType.Int32);
    //        p.Add("@pageSize", pageSize, System.Data.DbType.Int32);

    //        return DapperExtensions.QueryDapperStoreProc<RealEstateDto>(Procedures.sq_GetMultiRE, p).ToList();
    //    }
    //    public static List<RealEstateDto> GetMultiRE2(int Style, int Status, bool Type, int PageIndex, int PageSize)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@Style", Style, System.Data.DbType.Int32);
    //        p.Add("@Status", Status, System.Data.DbType.Int32);
    //        p.Add("@Type", Type, System.Data.DbType.Boolean);

    //        p.Add("@PageIndex", PageIndex, System.Data.DbType.Int32);
    //        p.Add("@PageSize", PageSize, System.Data.DbType.Int32);

    //        return DapperExtensions.QueryDapperStoreProc<RealEstateDto>(Procedures.sq_GetMultiRE2, p).ToList();
    //    }
    //    public static List<RealEstateDto> GetTopREinProvince(int IdProvince,int Style, int PageIndex, int PageSize)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@IdProvince", IdProvince, System.Data.DbType.Int32);
    //        p.Add("@Style", Style, System.Data.DbType.Int32);
    //        p.Add("@PageIndex", PageIndex, System.Data.DbType.Int32);
    //        p.Add("@PageSize", PageSize, System.Data.DbType.Int32);

    //        return DapperExtensions.QueryDapperStoreProc<RealEstateDto>(Procedures.sq_GetTopREinProvince, p).ToList();
    //    }

    //    public static List<RealEstateDto> GetSaveRE(int idCtv, int pageIndex, int pageSize)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@idCtv", idCtv == null ? null : string.Join(",", idCtv), System.Data.DbType.String);
    //        p.Add("@pageIndex", pageIndex, System.Data.DbType.Int32);
    //        p.Add("@pageSize", pageSize, System.Data.DbType.Int32);

    //        return DapperExtensions.QueryDapperStoreProc<RealEstateDto>(Procedures.sq_GetSaveRE, p).ToList();
    //    }
    //    public static List<CountDocType> GetCountDocType(int idRE)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@IdRealEstate", idRE, System.Data.DbType.Int32);
    //        return DapperExtensions.QueryDapperStoreProc<CountDocType>(Procedures.Document_GETNUMFILES, p).ToList();
    //    }


    //    public static List<RealEstateDto> SearchListRE(SearchListREParam param)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@IdCtv", param.IdCtv == null ? null : string.Join(",", param.IdCtv), System.Data.DbType.String);
    //        p.Add("@IdUser", param.IdUserRequest, System.Data.DbType.Int32);
    //        p.Add("@IdProvince", param.IdProvince, System.Data.DbType.Int32);
    //        p.Add("@IdDistrict", param.IdDistrict == null ? null : string.Join(",", param.IdDistrict), System.Data.DbType.String);
    //        p.Add("@IdWards", param.IdWards == null ? null : string.Join(",", param.IdWards), System.Data.DbType.String);
    //        p.Add("@Status", param.Status, System.Data.DbType.Int32);
    //        p.Add("@IdType", param.IdType, System.Data.DbType.Int32);
    //        p.Add("@Style", param.Style, System.Data.DbType.Byte);
    //        p.Add("@minPrice", param.minPrice, System.Data.DbType.Int32);
    //        p.Add("@maxPrice", param.maxPrice, System.Data.DbType.Int32);
    //        p.Add("@minArg", param.minArg, System.Data.DbType.Decimal);
    //        p.Add("@maxArg", param.maxArg, System.Data.DbType.Decimal);
    //        p.Add("@Address", param.Address == null ? null : string.Join(",", param.Address), System.Data.DbType.String);
    //        p.Add("@SearchKey", param.SearchKey == null ? null : string.Join(",", param.SearchKey), System.Data.DbType.String);
    //        p.Add("@pageIndex", param.pageIndex, System.Data.DbType.Int32);
    //        p.Add("@pageSize", param.pageSize, System.Data.DbType.Int32);

    //        return DapperExtensions.QueryDapperStoreProc<RealEstateDto>(Procedures.sq_SearchListRE, p).ToList();
    //    }
    //    public static List<DepositREDto> SearchListDeposit(string? Name, byte? IdType, byte? Status, string? StartDate,
    //                                            string? EndDate, int PageIndex, int PageSize)
    //    {
    //        var p = new DynamicParameters();
    //        p.Add("@Name", Name == null ? null : string.Join(",", Name), System.Data.DbType.String);
    //        p.Add("@IdType", IdType, System.Data.DbType.Byte);
    //        p.Add("@Status", Status, System.Data.DbType.Byte);
    //        p.Add("@StartDate", StartDate == null ? null : string.Join(",", StartDate), System.Data.DbType.String);
    //        p.Add("@EndDate", EndDate == null ? null : string.Join(",", EndDate), System.Data.DbType.String);
    //        p.Add("@pageIndex", PageIndex, System.Data.DbType.Int32);
    //        p.Add("@pageSize", PageSize, System.Data.DbType.Int32);

    //        return DapperExtensions.QueryDapperStoreProc<DepositREDto>(Procedures.sq_SearchListDeposit, p).ToList();
    //    }
    //}
}
