using UnityEngine;

namespace Core
{
    /*
     * -------------------------------------------------------
     * Этот класс контролирует внутриигровое время.
     * Рассчитывает смену для и ночи, времен года.
     * К нему привязана скорость развития всех событий в игре.
     * -------------------------------------------------------
     */
    
    public class GameTime : MonoBehaviour
    {
        public int Years { get; private set; } = 0;
        public int Months { get; private set; } = 0;
        public int Days { get; private set; } = 0;
        public int Hours { get; private set; } = 0;
        public int Minutes { get; private set; } = 0;
        public int Seconds { get; private set; } = 0;
        
        private float _totalSeconds = 0;
        private int _lastTick = 0;

        public float timeScale;

        public GameTime(float timeScale)
        {
            this.timeScale = timeScale;
        }
        
        private void Update()
        {
            // Накапливаем секунды с учетом временного масштаба
            _totalSeconds += Time.deltaTime * timeScale;
        
            UpdateTimeFromSeconds(_totalSeconds);
        }
    
        // Обновляет игровое время
        private void UpdateTimeFromSeconds(float totalSeconds)
        {
            int total = Mathf.FloorToInt(totalSeconds);
        
            // Обновляем только если изменилась секунда
            if (total != _lastTick)
            {
                _lastTick = total;
            
                // Конвертируем секунды в дату
                int seconds = total % 60;
                int minutes = (total / 60) % 60;
                int hours = (total / 3600) % 24;
                int days = (total / 86400) + 1;
            
                // Проверяем изменения и вызываем события
                bool dayChanged = Days != days;
                bool hourChanged = Hours != hours;
                bool minuteChanged = Minutes != minutes;
            
                Seconds = seconds;
                Minutes = minutes;
                Hours = hours;
                Days = days;
                
            }
        }

    }
}