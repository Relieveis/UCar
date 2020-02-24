using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Dapper.Contrib.Extensions;

namespace Honotop.WMS.Data.Domins
{
    public class DBHelper
    {
        /// <summary>
        /// 返回一条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<T> ExcuteAsycn<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (var conn = DBConnention.GetDbConnection())
            {
                var result = await conn.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);
                return result.FirstOrDefault();
            }
        }


        /// <summary>
        /// 返回一条数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static T Excute<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (var conn = DBConnention.GetDbConnection())
            {               
                var result = conn.Query<T>(sql, param, transaction,commandTimeout:commandTimeout,commandType:commandType);
                return result.FirstOrDefault();
            }
        }
        /// <summary>
        /// 执行sql
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static int ExcuteSql (string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            using (var conn = DBConnention.GetDbConnection())
            {
                var result = conn.Execute(sql, param, transaction, commandTimeout: commandTimeout, commandType: commandType);
                return result;
            }
        }
        /// <summary>
        /// 返回一个list数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<IList<T>> ExcuteAsycnList<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            try
            {
                using (var conn = DBConnention.GetDbConnection())
                {
                    var result = await conn.QueryAsync<T>(sql, param, transaction, commandTimeout, commandType);
                    return result.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// 返回一个list数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <param name="transaction"></param>
        /// <param name="commandTimeout"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static IList<T> ExcuteList<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            try
            {
                using (var conn = DBConnention.GetDbConnection())
                {
                    var result = conn.Query<T>(sql, param, transaction, commandTimeout: commandTimeout, commandType: commandType);
                    return result.ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
