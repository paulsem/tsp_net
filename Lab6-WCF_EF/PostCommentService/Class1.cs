using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.Text;
using AutoMapper;
using AutoMapper.Configuration;
using Lab6_WCF_EF;

namespace PostCommentService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServicePostComment : IPostComment
    {
        /// <summary>
        /// Instanta a clasei ServicePost, clasa ce expune metode de lucru cu EF pentru
        /// baza de date WCF.
        /// Exemplu de cod din aceasta clasa, ServicePost. Vedeti acces la context.
        public List<Post> GetAll()
        {
            List<Post> lp = new List<Post>();
            using (var context = new ModelPostBlogContainer())
            {
                lp = context.Posts.Include(p => p.Comments).ToList();
            }
            return lp;
        }
        /// </summary>
        /// 
    }

}
