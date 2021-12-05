using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace MovieInformationRepository.DapperHelper
{
    public class DbHelper : IDbHelper
    {
        /// <summary>
        /// IConfiguration instance
        /// </summary>
        private readonly IConfiguration _config;

        /// <summary>
        /// Database ConnectionString Instance
        /// </summary>
        private const string Connectionstring = "DefaultConnection";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="config"></param>
        public DbHelper(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Dispose method incase transaction failed
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// Dappper method for executing query
        /// </summary>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            return db.Query<int>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        /// <summary>
        /// Dapper Method to get record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T Get<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            return db.Query<T>(sp, parms, commandType: commandType).FirstOrDefault();
        }

        /// <summary>
        /// Method to get all the records
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public List<T> GetAll<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            return db.Query<T>(sp, parms, commandType: commandType).ToList();
        }

        /// <summary>
        /// Sql Connection method
        /// </summary>
        /// <returns></returns>
        public DbConnection GetDbConnection()
        {
            return new SqlConnection(_config.GetConnectionString(Connectionstring));
        }

        /// <summary>
        /// To Insert the record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T Insert<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }

        /// <summary>
        /// To update the record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sp"></param>
        /// <param name="parms"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T Update<T>(string sp, DynamicParameters parms, CommandType commandType = CommandType.StoredProcedure)
        {
            T result;
            using IDbConnection db = new SqlConnection(_config.GetConnectionString(Connectionstring));
            try
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();

                using var tran = db.BeginTransaction();
                try
                {
                    result = db.Query<T>(sp, parms, commandType: commandType, transaction: tran).FirstOrDefault();
                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (db.State == ConnectionState.Open)
                    db.Close();
            }

            return result;
        }
    }
}
