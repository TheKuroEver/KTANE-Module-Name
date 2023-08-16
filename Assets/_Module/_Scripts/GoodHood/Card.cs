using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private TextMesh _name;
    [SerializeField] private TextMesh _department;
    [SerializeField] private TextMesh _bosian;

    public string NameValue {
        get { return _name.text; }
        set { _name.text = value; }
    }
    public string DepartmentValue {
        get { return _department.text; }
        set { _department.text = value; }
    }
    public string BosianValue {
        get { return _bosian.text; }
        set { _bosian.text = value; }
    }
}
