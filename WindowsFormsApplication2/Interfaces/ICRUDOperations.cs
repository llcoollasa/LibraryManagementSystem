using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public interface ICRUDOperations
    {
        int save();

        int update();

        int delete();

        bool get();

        ArrayList getAll();

        ArrayList search(Dictionary<string, string> parameters);

        ArrayList makeCollection(String sql);
    }
}
