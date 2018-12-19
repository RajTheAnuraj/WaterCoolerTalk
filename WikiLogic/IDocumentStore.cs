using System;
using WikiLogic.Models;

namespace WikiLogic
{
    public interface IDocumentStore
    {
        WikiDoc GetDocument(string DocId);

        void CreateDocument(WikiDoc doc);

        void EditDocument(WikiDoc doc);

    }
}
