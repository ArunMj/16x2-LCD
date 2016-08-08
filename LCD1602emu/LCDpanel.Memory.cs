﻿/*########################################
 * LCD panel simulator component for .net |
 * Author: arunmj001@gmail.com         |
 *########################################
*/

//Contains description about memory of lm1602 controller

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LCD1602emu
{
       public partial class LCDpanel
       {
            private byte[][] CGROM_1 = new byte[][]
            {  
                new byte[8] {0,0,0,0,0,0,0,0},             // space  0x20 ---32
                new byte[8] {4, 4, 4, 4, 4, 0, 4, 0 },     // !  -- 0x21
                new byte[8] { 10, 10, 10, 0, 0, 0, 0, 0 }, // "
                new byte[8] {10,10,31,10,31,10,10,0},      // #
                new byte[8] {4,15,20,14,5,30,4,0},         // $
                new byte[8] {24,25,2,4,8,19,3,0},          // %
                new byte[8] {12,18,20,8,21,18,13,0},       // &
                new byte[8] {12,4,8,0,0,0,0,0},            // '
                new byte[8] {4,8,16,16,16,8,4,0},          // (
                new byte[8] {4,2,1,1,1,2,4,0},             // )
                new byte[8] {4,21,14,4,14,21,4,0},         // *
                new byte[8] {0,4,4,31,4,4,0,0},            // +
                new byte[8] {0,0,0,0,12,4,8,0},            // ,
                new byte[8] {0,0,0,31,0,0,0,0},            // -
                new byte[8] {0,0,0,0,0,12,12,0},           // .
                new byte[8] {0,1,2,4,8,16,0,0},            // /
                new byte[8] {14,17,19,21,25,17,14,0},      // 0
                new byte[8] {4,12,4,4,4,4,14,0},           // 1
                new byte[8] {14,17,1,2,4,8,31,0},          // 2
                new byte[8] {31,2,4,2,1,1,30,0},           // 3
                new byte[8] {2,6,10,18,31,2,2,0},          // 4
                new byte[8] {31,16,30,1,1,1,30,0},         // 5
                new byte[8] {6,8,16,30,17,17,14,0},        // 6
                new byte[8] {31,1,2,4,8,8,8,0},            // 7
                new byte[8] {14,17,17,14,17,17,14,0},      // 8
                new byte[8] {14,17,17,15,1,2,12,0},        // 9
                new byte[8] {0,12,12,0,12,12,0,0},         // :
                new byte[8] {0,12,12,0,12,4,8,0},          // ;
                new byte[8] {2,4,8,16,8,4,2,0},            // <
                new byte[8] {0,0,31,0,31,0,0,0},           // =
                new byte[8] {8,4,2,1,2,4,8,0},             // >
                new byte[8] {14,17,1,2,4,0,4,0},           // ?
                new byte[8] {14,17,1,13,21,21,14,0},       // @
                new byte[8] {14,17,17,17,31,17,17,0},      // A
                new byte[8] {30,17,17,30,17,17,30,0},      // B
                new byte[8] {14,17,16,16,16,17,14,0},      // C
                new byte[8] {28,18,17,17,17,18,28,0},      // D
                new byte[8] {31,16,16,30,16,16,31,0},      // E
                new byte[8] {31,16,16,30,16,16,16,0},      // F
                new byte[8] {15,16,16,23,17,17,14,0},      // G
                new byte[8] {17,17,17,31,17,17,17,0},      // H
                new byte[8] {14,4,4,4,4,4,14,0},           // I
                new byte[8] {7,2,2,2,2,18,12,0},           // J
                new byte[8] {17,18,20,24,20,18,17,0},      // K
                new byte[8] {16,16,16,16,16,16,31,0},      // L
                new byte[8] {17,27,21,21,17,17,17,0},      // M
                new byte[8] {17,17,25,21,19,17,17,0},      // N
                new byte[8] {14,17,17,17,17,17,14,0},      // O
                new byte[8] {30,17,17,30,16,16,16,0},      // P
                new byte[8] {14,17,17,17,21,18,13,0},      // Q
                new byte[8] {30,17,17,30,20,18,17,0},      // R
                new byte[8] {15,16,16,14,1,1,30,0},        // S
                new byte[8] {31,4,4,4,4,4,4,0},            // T
                new byte[8] {17,17,17,17,17,17,14,0},      // U
                new byte[8] {17,17,17,17,17,10,4,0},       // V
                new byte[8] {17,17,17,21,21,21,10,0},      // W
                new byte[8] {17,17,10,4,10,17,17,0},       // X
                new byte[8] {17,17,17,10,4,4,4,0},         // Y
                new byte[8] {31,1,2,4,8,16,31,0},          // Z ----90
                new byte[8] {30,16,16,16,16,16,30,0},      // [
                new byte[8] {17,10,31,4,30,4,4,0},         //yuvan
                new byte[8] {14,2,2,2,2,2,14,0},           // ]
                new byte[8] {4,10,17,0,0,0,0,0},           // ^
                new byte[8] {0,0,0,0,0,0,31,0},            // _
                new byte[8] {8,4,2,0,0,0,0,0},             // `
                new byte[8] {0,0,14,1,15,17,15,0},         // a 
                new byte[8] {16,16,22,25,17,17,30,0},      // b
                new byte[8] {0,0,14,16,16,17,14,0},        // c
                new byte[8] {1,1,13,19,17,17,15,0},        // d
                new byte[8] {0,0,14,17,31,16,14,0},        // e
                new byte[8] {6,9,8,28,8,8,8,0},            // f
                new byte[8] {0,15,17,17,15,1,14,0},        // g
                new byte[8] {16,16,16,22,25,17,17,0},      // h
                new byte[8] {4,0,12,4,4,4,14,0},           // i
                new byte[8] {2,0,6,2,2,18,12,0},           // j
                new byte[8] {16,16,18,20,24,20,18,0},      // k
                new byte[8] {12,4,4,4,4,4,14,0},           // l
                new byte[8] {0,0,30,21,21,21,21,0},        // m
                new byte[8] {0,0,22,25,17,17,17,0},        // n
                new byte[8] {0,0,14,17,17,17,14,0},        // o
                new byte[8] {0,0,30,17,30,16,16,0},        // p
                new byte[8] {0,13,19,15,1,1,1,0},          // q
                new byte[8] {0,22,25,16,16,16,16,0},       // r
                new byte[8] {0,0,15,16,14,1,30,0},         // s
                new byte[8] {8,8,28,8,8,9,6,0},            // t
                new byte[8] {0,0,17,17,17,19,13,0},        // u
                new byte[8] {0,0,17,17,17,10,4,0},         // v
                new byte[8] {0,0,17,17,21,21,10,0},        // w
                new byte[8] {0,0,17,10,4,10,17,0},         // x
                new byte[8] {0,17,17,15,1,1,14,0},         // y
                new byte[8] {0,0,31,2,4,8,31,0},           // z
                new byte[8] {2,4,4,8,4,4,2,0},             // {
                new byte[8] {4,4,4,4,4,4,4,0},             // |
                new byte[8] {8,4,4,2,4,4,8,0},             // }
                new byte[8] {0,4,2,31,2,4,0,0},            // right arrow
                new byte[8] {0,4,8,31,8,4,0,0},            // left arrow
            };
           private byte[][] CGROM_2 = new byte[][]
           {
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {0,0,0,0,0,0,0,0},
                 new byte[8] {31,31,31,31,31,31,31,31},              // cursor 
           };
       }
}
