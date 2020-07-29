using Kubectl.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kubectl.Core.Data.Interfaces
{
    public interface ICharacterDependency
    {
        Character CreateCharacter();
        ICollection<Character> CreateCharacterCollection(int length);
    }
}
