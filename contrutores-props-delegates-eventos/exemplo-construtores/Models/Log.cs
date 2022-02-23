namespace exemplo_construtores.Models{

    public class Log{

        private static Log _log;
        public string PropriedadeLog;
        private Log(){

        }

        public static Log GetInstance(){
            if(_log == null){
                _log = new Log();
            }
            return _log;
        }
    }

}