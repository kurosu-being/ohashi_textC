using System;

// 問題 1.3

// １．Personクラスを継承し、Studentクラスを定義してください。
//     Studentには、２つのプロパティ、Grade（学年）とClassNumber（組）を追加してください。
//     ２つのプロパティは共にint型としてください。

// ２．Studentクラスのインスタンスを生成するコードを書いてください。
//     この時、すべてのプロパティに値を設定してください。

// ３．２で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。

// ４．２で生成したインスタンスをPerson型およびobject型の変数に代入できることを確認してください。

namespace Practice1_3 {
    /// <summary>
    /// Studentクラスのインスタンスを生成し、各プロパティの値をコンソールに出力する
    /// その後、Person型およびobject型の変数に代入できることを確認する
    /// </summary>
    internal class Program {
        static void Main(string[] args) {
            // 2の解答
            Student wStudent = new Student();
            wStudent.Name = "大橋 陸";
            wStudent.Birthday = new DateTime(2002, 10, 4);
            wStudent.Grade = 1;
            wStudent.ClassNumber = 2;
            // 3の解答
            Console.WriteLine($"{ wStudent.Grade } 年 { wStudent.ClassNumber } 組の { wStudent.Name} " +
                $"です。誕生日は { wStudent.Birthday.ToString("yyyy年MM月dd日") }  です");
            // 4の解答
            Person wPerson = wStudent;
            object wObj = wStudent;
        }
    }
}
