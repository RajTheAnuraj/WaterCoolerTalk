using System;
using System.Collections.Generic;

namespace WikiLogic
{
    public interface IIndexStore
    {
        List<string> GetTagsForDocument(string DocId);

        void SaveTagsForDocument(string DocId, List<string> tags);

        void RemoveTagsForDocument(string DocId);
    }
}
