﻿using System.Collections.Generic;public class UserComparator : IEqualityComparer<User>
{
    public bool Equals(User x, User y)
    {
        return x.Name == y.Name;
    }

    public int GetHashCode(User obj)
    {
        return obj.GetHashCode();
    }
}
