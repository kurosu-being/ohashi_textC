using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 問題 1.3

// １．Personクラスを継承し、Studentクラスを定義してください。
//     Studentには、２つのプロパティ、Grade（学年）とClassNumber（組）を追加してください。
//     ２つのプロパティは共にint型としてください。

// ２．Studentクラスのインスタンスを生成するコードを書いてください。
//     この時、すべてのプロパティに値を設定してください。

// ３．２で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。

// ４．２で生成したインスタンスをPerson型およびobject型の変数に代入できることを確認してください。

namespace Practice1_3 {
    internal class Program {
        static void Main(string[] args) {
            // 2の解答
            Student student = new Student();
            student.Name = "大橋 陸";
            student.Birthday = new DateTime(2002, 10, 4);
            student.Grade = 1;
            student.ClassNumber = 2;
            // 3の解答
            Console.WriteLine(student.Grade + "年" + student.ClassNumber + "組の" + student.Name
                + "です。誕生日は " + student.Birthday.ToString("yyyy年MM月dd日") + "です");
            // 4の解答
            Person wPerson = student;
            object wObj = student;
        }
    }
    public class Person {
        public string Name;
        public DateTime Birthday;
    }
    // 1の解答
    public class Student : Person {
        public int Grade;
        public int ClassNumber;
    }
}
