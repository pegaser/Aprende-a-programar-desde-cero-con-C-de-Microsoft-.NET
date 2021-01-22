using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq.Expressions;

namespace CodeDomExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();
            CodeNamespace myNamespace = new CodeNamespace("MyNamespace");
            myNamespace.Imports.Add(new CodeNamespaceImport("System"));
            CodeTypeDeclaration myClass = new CodeTypeDeclaration("MyClass");
            CodeEntryPointMethod myMain = new CodeEntryPointMethod();
            CodeMethodInvokeExpression myFirstLine = new CodeMethodInvokeExpression
            (
                new CodeTypeReferenceExpression("Console"), 
                "WriteLine", 
                new CodePrimitiveExpression("Hello World!")
            );
            compileUnit.Namespaces.Add(myNamespace);
            myNamespace.Types.Add(myClass);
            myClass.Members.Add(myMain);
            myMain.Statements.Add(myFirstLine);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            using (StreamWriter sw = new StreamWriter("HelloWorld.cs", false))
            {
                IndentedTextWriter tw = new IndentedTextWriter(sw, " ");
                provider.GenerateCodeFromCompileUnit(compileUnit, tw, new CodeGeneratorOptions());
                tw.Close();
            }

            BlockExpression blockExpr = Expression.Block
            (
                Expression.Call
                (
                    null,
                    typeof(Console).GetMethod("Write", new Type[] { typeof(String) }),
                    Expression.Constant("Hello ")
                ),
                Expression.Call
                (
                    null,
                    typeof(Console).GetMethod("WriteLine", new Type[] { typeof(String) }),
                    Expression.Constant("World!")
                )
            );

            Expression.Lambda<Action>(blockExpr).Compile()();

            Console.Read();
        }
    }
}
