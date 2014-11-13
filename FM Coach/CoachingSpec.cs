using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_Coach
{
    #region Main class: CoachingSpec
    class CoachingSpec
    {
        private Decimal[] limits;
        protected Decimal score;

        protected CoachingSpec(Decimal lim10, Decimal lim15, Decimal lim20, Decimal lim25, Decimal lim30, Decimal lim35, Decimal lim40, Decimal lim45, Decimal lim50)
        {
            limits = new Decimal[] {lim10, lim15, lim20, lim25, lim30, lim35, lim40, lim45, lim50 };
            score = 0;
        }

        public float getNumberOfStars()
        {
            float nbs = 0.5f;

            if (score >= limits[8])
            {
                nbs = 5;
            }
            else if (score >= limits[7])
            {
                nbs = 4.5f;
            }
            else if (score >= limits[6])
            {
                nbs = 4;
            }
            else if (score >= limits[5])
            {
                nbs = 3.5f;
            }
            else if (score >= limits[4])
            {
                nbs = 3;
            }
            else if (score >= limits[3])
            {
                nbs = 2.5f;
            }
            else if (score >= limits[2])
            {
                nbs = 2;
            }
            else if (score >= limits[1])
            {
                nbs = 1.5f;
            }
            else if (score >= limits[0])
            {
                nbs = 1;
            }


            return nbs;
        }
    }

    #endregion

    #region Sub classes

    class CoachingSpecStrength : CoachingSpec
    {
        public CoachingSpecStrength(Decimal fitness, Decimal determination, Decimal discipline, Decimal motivation)
            : base(30, 60, 90, 120, 150, 180, 210, 240, 270)
        {
            score = fitness * 9 + (determination + discipline + motivation) * 2;
        }
    }

    class CoachingSpecAerobic : CoachingSpec
    {
        public CoachingSpecAerobic(Decimal fitness, Decimal determination, Decimal discipline, Decimal motivation)
            : base(30, 60, 90, 120, 150, 180, 210, 240, 270)
        {
            score = fitness * 9 + (determination + discipline + motivation) * 2;
        }
    }

    class CoachingSpecStopping : CoachingSpec
    {
        public CoachingSpecStopping(Decimal goalkeepers, Decimal determination, Decimal discipline, Decimal motivation)
            : base(10, 20, 30, 40, 50, 60, 70, 80, 90)
        {
            score = goalkeepers * 2 + determination + discipline + motivation;
        }
    }

    class CoachingSpecHandling : CoachingSpec
    {
        public CoachingSpecHandling(Decimal goalkeepers, Decimal determination, Decimal discipline, Decimal motivation)
            : base(10, 20, 30, 40, 50, 60, 70, 80, 90)
        {
            score = goalkeepers * 2 + determination + discipline + motivation;
        }
    }

    class CoachingSpecTactics : CoachingSpec
    {
        public CoachingSpecTactics(Decimal tactical, Decimal determination, Decimal discipline, Decimal motivation)
            : base(10, 20, 30, 40, 50, 60, 70, 80, 90)
        {
            score = tactical * 2 + determination + discipline + motivation;
        }
    }

    class CoachingSpecBallControl : CoachingSpec
    {
        public CoachingSpecBallControl(Decimal technical, Decimal mental, Decimal determination, Decimal discipline, Decimal motivation)
            : base(30, 60, 90, 120, 150, 180, 210, 240, 270)
        {
            score = technical * 6 + mental * 3 + (determination + discipline + motivation) * 2;
        }
    }

    class CoachingSpecDefending : CoachingSpec
    {
        public CoachingSpecDefending(Decimal defending, Decimal tactical, Decimal determination, Decimal discipline, Decimal motivation)
            : base(40, 80, 120, 160, 200, 240, 280, 320, 360)
        {
            score = defending * 8 + (tactical + determination + discipline + motivation) * 3;
        }
    }

    class CoachingSpecAttacking : CoachingSpec
    {
        public CoachingSpecAttacking(Decimal attacking, Decimal tactical, Decimal determination, Decimal discipline, Decimal motivation)
            : base(30, 60, 90, 120, 150, 180, 210, 240, 270)
        {
            score = attacking * 6 + tactical * 3 + (determination + discipline + motivation) * 2;
        }
    }

    class CoachingSpecShooting : CoachingSpec
    {
        public CoachingSpecShooting(Decimal technical, Decimal attacking, Decimal determination, Decimal discipline, Decimal motivation)
            : base(30, 60, 90, 120, 150, 180, 210, 240, 270)
        {
            score = technical * 6 + attacking * 3 + (determination + discipline + motivation) * 2;
        }
    }

    #endregion
}
