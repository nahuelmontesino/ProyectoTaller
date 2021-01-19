using API.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
    interface IQuestionRepository : IRepository<Question>
    {
        void SaveQuestions(ISource pSource, string pDificulty, string pCategory, int pAmount, ISession session);
        void AddOption(Option pOption);
        void DeleteAllQuestions();
        List<Question> GetQuestions(int pSet, int pDificulty, int pCategory, int pAmount);
        List<string> GetCategoriesOfSet(ISource pSource, int set);
        List<string> GetDifficultiesOfCategory(ISource pSource, int set, int category);
    }
}
