using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game3D.Abstracts.Inputs
{
    public interface IInputReader
    {
       float Horizontal { get; }
       bool IsJump { get; }
    }

}
