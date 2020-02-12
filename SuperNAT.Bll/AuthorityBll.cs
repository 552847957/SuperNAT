﻿using Dapper;
using SuperNAT.Dal;
using SuperNAT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperNAT.Bll
{
    public class AuthorityBll
    {
        private AuthorityDal authorityDal = new AuthorityDal();

        public ReturnResult<bool> Add(Authority model)
        {
            using (authorityDal)
            {
                return authorityDal.Add(model);
            }
        }

        public ReturnResult<bool> Update(Authority model)
        {
            using (authorityDal)
            {
                return authorityDal.Update(model);
            }
        }

        public ReturnResult<bool> Delete(Authority model)
        {
            using (authorityDal)
            {
                return authorityDal.Delete(model);
            }
        }

        public ReturnResult<Authority> GetOne(Authority model)
        {
            using (authorityDal)
            {
                return authorityDal.GetOne(model);
            }
        }

        public ReturnResult<List<Authority>> GetList(string where)
        {
            using (authorityDal)
            {
                return authorityDal.GetList(where);
            }
        }
    }
}
