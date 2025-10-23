// 問題 1.3

// 1. Personクラスを継承し、Studentクラスを定義してください。
//    Studentには、2つのプロパティ、Grade（学年）とClassNumber（組）を追加してください。
//    2つのプロパティは共にint型としてください。

// 2. Studentクラスのインスタンスを生成するコードを書いてください。
//    この時、すべてのプロパティに値を設定してください。

// 3. 2で生成したインスタンスの各プロパティの値をコンソールに出力するコードを書いてください。

// 4. 2で生成したインスタンスをPerson型およびobject型の変数に代入できることを確認してください。
using System;

namespace Practice1_3 {
    internal class Program {
        static void Main(string[] args) {
            // 2の解答
            var wStudent = new Student("大橋 陸", new DateTime(2002, 10, 4),1,2);
            // 3の解答
            Console.WriteLine($"{wStudent.Grade} 年 {wStudent.ClassNumber} 組の {wStudent.Name} " +
                $"です。誕生日は {wStudent.Birthday.ToString("yyyy年MM月dd日")} です");
            // 4の解答
            Person wPerson = wStudent;
            object wObj = wStudent;
        }
    }
}
