using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionLive
{

    /// <summary>
    /// Шаблон живого организма
    /// </summary>
    interface livingOrganism
    {
        /// <summary>
        /// Нужно кушать и т.д.
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        string metabolism(string food);

        /// <summary>
        /// Бог сказал плодиться
        /// </summary>
        void self_reproduction();

        /// <summary>
        /// Развивается пацаны
        /// </summary>
        void improvement();

        /// <summary>
        /// Необходимость в обработке информации (хранении передачи)
        /// </summary>
        void InformationProcessing();

        /// <summary>
        /// Стремление\способы выживания
        /// </summary>
        void DesireToSurvive();

    }

    //Клетка
    abstract public class Cellula : livingOrganism
    {
        /// <summary>
        /// Цитоплазматическая мембрана
        /// </summary>
        string Cytoplasmic_Membrane;

        /// <summary>
        /// Органоиды
        /// </summary>
        private abstract class Organoids
        {
            private abstract class Core
            {
                public abstract string Membrane();
                public abstract string Nucleus();
                public abstract string Karyoplasm();
                public abstract string Сhromosome();
            }
        }

        /// <summary>
        /// Память
        /// </summary>
        internal struct Memory
        {
            /// <summary>
            /// Забывать
            /// </summary>
            /// <returns></returns>
            public static string Forget()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Вспоминать
            /// </summary>
            /// <param name="context"></param>
            /// <returns></returns>
            public static string Remember(string context)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Способы саморазвития
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void improvement()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Реализация метаболизма
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string metabolism(string food)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Реализация самовоспроизведения
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void self_reproduction()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Эгоизм
        /// </summary>
        public void Egoizm() { }

        /// <summary>
        /// Черезвычайная самоуверенность
        /// </summary>
        public void ExtremeSelfConfidence() { }

        /// <summary>
        /// Обработка информации 
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void InformationProcessing()
        {

            throw new NotImplementedException();
        }

        /// <summary>
        /// Стремление\способы выживания
        /// </summary>
        public void DesireToSurvive() => InformationProcessing();

    }

    ///древнейшие из плацентарных насекомоядных — эндотерии
    abstract public class Endotheria : Cellula
    {

        /// <summary>
        /// Доминирование
        /// </summary>
        abstract public void Dominance();

        /// <summary>
        /// Потребление
        /// </summary>
        abstract public void Consumption();

        /// <summary>
        /// Чтобы выжить нукжно потреблять
        /// </summary>
        new void DesireToSurvive() => Consumption();
    }

    /// <summary>
    /// Примитивные насекомоядные млекопитяющие
    /// </summary>
    abstract public class PrimitiveInsectivorousMammals : Endotheria { }

    /// <summary>
    /// Приматы
    /// </summary>
    abstract public class Primates : PrimitiveInsectivorousMammals { };

    /// <summary>
    /// Ардипитеки — род древних гоминид
    /// </summary>
    abstract public class Ardipithecus : Primates { }

    /// <summary>
    /// встралопите́ки — род ископаемых высших приматов
    /// </summary>
    abstract public class Australopithecus : Ardipithecus { }


    /// <summary>
    /// Язык
    /// </summary>
    interface Language_Russian
    {
        /// <summary>
        /// Способность говорить
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        string Speak(string context);
        string Understand(string Speek);
    }
    /// <summary>
    /// Традиции
    /// </summary>
    interface Traditiones
    {
        /// <summary>
        /// Взаимоуважение
        /// </summary>
        void MutualRespect();
    }
    /// <summary>
    /// История
    /// </summary>
    interface Historia
    {
        /// <summary>
        /// Опыт ошибок и их решений
        /// </summary>
        void ExperienceOfMistakesAndTheirSolutions();
    }
    /// <summary>
    /// Техносфера
    /// </summary>
    interface Technosphere
    {

        /// <summary>
        /// Эксплуатация и разработки техносферы
        /// </summary>
        void useTechnosphere();
    }

    /// <summary>
    /// Человек разумный 
    /// </summary>
    public class HomoSapiens : Australopithecus, Language_Russian, Traditiones, Historia, Technosphere
    {

        /// <summary>
        /// Взаимоуважение
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void MutualRespect()
        {
            //Не реализованно [для упрощения]
            throw new NotImplementedException();
        }

        /// <summary>
        /// Опыт ошибок и их решений
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void ExperienceOfMistakesAndTheirSolutions()
        {
            //Не реализованно [для упрощения]
            throw new NotImplementedException();
        }

        /// <summary>
        /// Использование техносферы
        /// </summary>
        public void useTechnosphere()
        {
            ///Для упрощения труда, саморазвития
            Console.WriteLine("To simplify labor");
        }

        /// <summary>
        /// Говорить
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string Speak(string context)
        {
            //Не реализованно [для упрощения]
            throw new NotImplementedException();
        }

        /// <summary>
        /// Понимать
        /// </summary>
        /// <param name="Speek"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string Understand(string Speek)
        {
            //Не реализованно [для упрощения]
            throw new NotImplementedException();
        }

        /// <summary>
        /// Способы саморазвития
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void improvement()
        {
            //Не реализованно [для упрощения]
            throw new NotImplementedException();
        }
        /// <summary>
        /// Реализация метаболизма
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string metabolism(string food)
        {
            //Не реализованно [для упрощения]
            throw new NotImplementedException();
        }

        /// <summary>
        /// Реализация самовоспроизведения
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void self_reproduction()
        {
            //Не реализованно [для упрощения]
            throw new NotImplementedException();
        }

        /// <summary>
        /// Замена доменирование на коллективную деятельность, на основе взаимоуважения.
        /// </summary>
        public override void Dominance() => MutualRespect();


        /// <summary>
        /// Контролируемое потребление
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public override void Consumption()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Потребление информации ради улушчения жизни общества
        /// </summary>
        new public void InformationProcessing() => MutualRespect();
    }

    /// <summary>
    /// [Шутка]: Человек с пустым умом (современный)
    /// </summary>
    public abstract class HomoInanisAnimo : HomoSapiens
    {



        /// <summary>
        /// Некотролирунмое потребление
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        new public void Consumption()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Доминирование на основе эгоцентризма
        /// </summary>
        new void Dominance() => Egoizm();

        /// <summary>
        /// Взаимоуважение, заменяем на эгоизм
        /// </summary>
        new void MutualRespect() => Dominance();

        /// <summary>
        /// Техносфера для доминирования.
        /// </summary>
        new public void useTechnosphere() => Dominance();

        /// <summary>
        /// Техносфера для доминирования.
        /// </summary>
        new public void improvement() => Consumption();

        /// <summary>
        /// Потребление информации ради её потребления
        /// </summary>
        new public void InformationProcessing() => Consumption();

        /// <summary>
        /// Забываем историю
        /// </summary>
        new void ExperienceOfMistakesAndTheirSolutions() => Memory.Forget();

    }

    //...
}
