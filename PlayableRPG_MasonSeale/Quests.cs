using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayableRPG_MasonSeale
{
    internal class Quests
    {
        Enemy _enemy;
        Player _player;

        int _questNum;
        public string _quest;
        public bool _isCompleted;

        public Quests(int questNum, string quest, bool isCompleted)
        {
            _questNum = questNum;
            _quest = quest;
            _isCompleted = isCompleted;

        }

        public void DrawQuests()
        {
            Console.SetCursorPosition(50, 20 + _questNum);
            
            if (_isCompleted == true)
            {
                _quest = "Done                     ";
            }
            
            Console.WriteLine(_quest);

        }

        public void ClearQuests()
        {

        }

    }
}
