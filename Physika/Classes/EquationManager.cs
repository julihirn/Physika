using Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Physika.Classes {
    public static class EquationManager {
        public static List<TemplateEquationGroup> Equations = new List<TemplateEquationGroup>();
        public static void LoadEquations() {
            try {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Environment.CurrentDirectory + @"\Equations\");
                System.IO.FileInfo[] aryFi = di.GetFiles("*.peq");
                foreach (System.IO.FileInfo fi in aryFi) {
                    DocumentHandler.Open(fi.FullName);

                    TemplateEquationGroup EquationGroup = new TemplateEquationGroup();

                    EquationGroup.Name = DocumentHandler.GetStringVariable("Name");

                    List<TemplateEquation> Formulas = new List<TemplateEquation>();
                    /*
                     * TemplateEquationGroup        = Group of Equations for the same law, i.e., 'Ohms Law'
                     * ->TemplateEquation           = An Equation Collection equalling a variable, i.e., V=I*R, V=P/I, etc.
                     * -->TemplateVariablePairing   = An Expression with required variable inputs, i.e., I*R with I and R marked as variables
                     * --->TemplateVariable         = A Variable with symbol that is marked for usage
                     * 
                     */
                    foreach (ParameterStructure Parm in DocumentHandler.PARM) {
                        string OutputName = "xvar";
                        if (DocumentHandler.IsDefinedInParameter("Output", Parm)) {
                            OutputName = (string)Parm.GetVariable("Output", true, DataType.STR);
                        }
                        TemplateEquation Formula = new TemplateEquation(GetVariable(OutputName));
                        if (DocumentHandler.IsDefinedInParameter("Equations", Parm)) {
                            List<string> Data = GetList(Parm.GetVariable("Equations", false, DataType.STR));
                            foreach (string ListedEquation in Data) {
                                Formula.Equations.Add(ExtractExpressionData(ListedEquation));
                            }
                        }
                        Formulas.Add(Formula);
                    }
                    EquationGroup.Forumlas = Formulas;
                    Equations.Add(EquationGroup);
                }
            }
            catch { }
        }
        private static List<string> GetList(object Input) {
            if (Input == null) {
                return new List<string>();
            }
            if (Input.GetType() == typeof(List<string>)) {
                return (List<string>)Input;
            }
            return new List<string>();
        }
        private static TemplateVariablePairing ExtractExpressionData(string Expression) {
            TemplateVariablePairing Pairing = new TemplateVariablePairing();
            Pairing.Expression = Expression;
            List<string> KnownVariables = MathHandler.ExtractVariablesFromExpression(Expression);
            foreach (string KVar in KnownVariables) {
                UnitType? UntType = FindUnitType(KVar);
                if (UntType == null) {
                    Pairing.Inputs.Add(new TemplateVariable(KVar));
                }
                else {
                    Pairing.Inputs.Add(new TemplateVariable(KVar, UntType));
                }
            }
            return Pairing;
        }
        private static UnitType? FindUnitType(string Name) {
            UnitType? AttachUnit = null;
            foreach (UnitType UntTpe in ConversionHandler.UnitTypes) {
                if (UntTpe.VariableName == Name) {
                    AttachUnit = UntTpe;
                    break;
                }
            }
            return AttachUnit;
        }
        public static TemplateVariable GetVariable(string Name) {
            UnitType? AttachUnit = FindUnitType(Name);
            if (AttachUnit == null) {
                return new TemplateVariable(Name);
            }
            else {
                return new TemplateVariable(Name, AttachUnit);
            }
        }
        public static TemplateVariablePairing CopyPairing(TemplateVariablePairing Pairing) {
            TemplateVariablePairing TempVarPair = new TemplateVariablePairing();
            string Expression = Pairing.Expression;
            TempVarPair.Expression = Expression;
            foreach(TemplateVariable TempVar in Pairing.Inputs) {
                TempVarPair.Inputs.Add(CopyVariable(TempVar));
            }
            return TempVarPair;
        }
        public static TemplateVariable CopyVariable(TemplateVariable Variable) {
            string Name = Variable.VariableName;
            UnitType ?Type = Variable.AttachedUnit;
            if (Type == null) {
                return new TemplateVariable(Variable.VariableName);
            }
            else {
                return new TemplateVariable(Variable.VariableName, Type);
            }
        }
    }
    public class TemplateEquationGroup {
        string name = "";
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public List<TemplateEquation> Forumlas = new List<TemplateEquation>();
    }
    public class TemplateEquation {
        TemplateVariable? result;
        public TemplateVariable? Result {
            get { return result; }
        }
        public List<TemplateVariablePairing> Equations = new List<TemplateVariablePairing>();
        public TemplateEquation(TemplateVariable Equal) {
            result = Equal;
        }
    }
    public class TemplateVariablePairing {
        List<TemplateVariable> inputs = new List<TemplateVariable>();
        public List<TemplateVariable> Inputs {
            get { return inputs; }
        }
        public string Expression = "";
    }

    public class TemplateVariable {
        UnitType? attachedUnit = null;
        public UnitType? AttachedUnit {
            get { return attachedUnit; }
        }
        string variableName = "";
        public string VariableName {
            get { return variableName; }
        }
        TemplateVariableType varType = TemplateVariableType.Scalar;
        public TemplateVariableType Type {
            get { return varType; }
        }
        public TemplateVariable(string Name) {
            variableName = Name;
            varType = TemplateVariableType.Scalar;
        }
        public TemplateVariable(string Name, UnitType UnitGroup) {
            variableName = Name;
            varType = TemplateVariableType.United;
            attachedUnit = UnitGroup;
        }
    }
    public enum TemplateVariableType {
        Scalar = 0x01,
        United = 0x02
    }
}
