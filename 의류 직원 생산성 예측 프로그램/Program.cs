using System;
using 의류_직원_생산성_예측_프로그램ML.Model;

namespace 의류_직원_생산성_예측_프로그램
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput()
            {
                Date = "1/1/2015",               //날짜  (예측할 날짜)
                Quarter = "Quater1",             // 4주를 1분기로 
                Department = "sweing",           // 팀의 부서
                Day ="Thursday",                 // 요일  (예측 요일) 딱히 필요없음 그냥 넣음
                Team = 8,                        // 인스턴스와 연관된 팀 번호
                Targeted_productivity = 0.75f,   // 회사가 지정한 생산률
                Smv = 22.42f,                    // 작업에 할당 된 시간
                Wip = 1000,                      // 진행중인 작업
                Over_time = 7000,                // 초과 근무 시간
                Incentive = 60,                  // 인센티브 (보너스)
                Idle_time = 0,                   // 생산이 중단된 시간
                Idle_men = 0,                    // 쉬는 근로자
                No_of_style_change = 0,          // 스타일의 변화
                No_of_workers = 59               // 팀의 작업자 수 

            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine("예측 생산량 : {0}", result.Score);
        }
    }
}
