using System;

namespace Practice1_3 {
    /// <summary>
    /// Personクラスを継承し、加えてGradeとClassNumberプロパティを持つクラス
    /// </summary>
    // 1の解答
    public class Student : Person {
        /// <summary>
        /// 学年
        /// </summary>
        public int Grade { get; set; }
        /// <summary>
        /// 組
        /// </summary>
        public int ClassNumber { get; set; }
        /// <summary>
        /// 生徒の各プロパティを初期化するコンストラクタ
        /// </summary>
        /// <param name="vName">名前</param>
        /// <param name="vBirthday">生年月日</param>
        /// <param name="vGrade">学年</param>
        /// <param name="vClassNumber">組</param>
        public Student(string vName, DateTime vBirthday, int vGrade, int vClassNumber) {
            this.Name = vName;
            this.Birthday = vBirthday;
            this.Grade = vGrade;
            this.ClassNumber = vClassNumber;
        }
    }
}
