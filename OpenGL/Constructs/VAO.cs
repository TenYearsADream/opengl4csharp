﻿using System;

#if USE_NUMERICS
using System.Numerics;
#endif

namespace OpenGL
{
    public class VAO<T1> : GenericVAO
        where T1 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, string attribName, VBO<int> elementArray)
            : base(program)
        {
            GenericVAO.GenericVBO[] vbos = new GenericVBO[2];
            vbos[0] = new GenericVBO(vbo1.ID, attribName, vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }

        public VAO(ShaderProgram program, VBO<T1> vbo1, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 1) throw new Exception(string.Format("Expected an array of 1 name, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[2];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class VAO<T1, T2> : GenericVAO
        where T1 : struct
        where T2 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, VBO<T2> vbo2, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 2) throw new Exception(string.Format("Expected an array of 2 names, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[3];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(vbo2.ID, attribNames[1], vbo2.Count, vbo2.Size, vbo2.PointerType, vbo2.BufferTarget, vbo2.Divisor);
            vbos[2] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class VAO<T1, T2, T3> : GenericVAO
        where T1 : struct
        where T2 : struct
        where T3 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, VBO<T2> vbo2, VBO<T3> vbo3, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 3) throw new Exception(string.Format("Expected an array of 3 names, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[4];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(vbo2.ID, attribNames[1], vbo2.Count, vbo2.Size, vbo2.PointerType, vbo2.BufferTarget, vbo2.Divisor);
            vbos[2] = new GenericVBO(vbo3.ID, attribNames[2], vbo3.Count, vbo3.Size, vbo3.PointerType, vbo3.BufferTarget, vbo3.Divisor);
            vbos[3] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class VAO<T1, T2, T3, T4> : GenericVAO
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, VBO<T2> vbo2, VBO<T3> vbo3, VBO<T4> vbo4, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 4) throw new Exception(string.Format("Expected an array of 4 names, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[5];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(vbo2.ID, attribNames[1], vbo2.Count, vbo2.Size, vbo2.PointerType, vbo2.BufferTarget, vbo2.Divisor);
            vbos[2] = new GenericVBO(vbo3.ID, attribNames[2], vbo3.Count, vbo3.Size, vbo3.PointerType, vbo3.BufferTarget, vbo3.Divisor);
            vbos[3] = new GenericVBO(vbo4.ID, attribNames[3], vbo4.Count, vbo4.Size, vbo4.PointerType, vbo4.BufferTarget, vbo4.Divisor);
            vbos[4] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class VAO<T1, T2, T3, T4, T5> : GenericVAO
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, VBO<T2> vbo2, VBO<T3> vbo3, VBO<T4> vbo4, VBO<T5> vbo5, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 5) throw new Exception(string.Format("Expected an array of 5 names, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[6];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(vbo2.ID, attribNames[1], vbo2.Count, vbo2.Size, vbo2.PointerType, vbo2.BufferTarget, vbo2.Divisor);
            vbos[2] = new GenericVBO(vbo3.ID, attribNames[2], vbo3.Count, vbo3.Size, vbo3.PointerType, vbo3.BufferTarget, vbo3.Divisor);
            vbos[3] = new GenericVBO(vbo4.ID, attribNames[3], vbo4.Count, vbo4.Size, vbo4.PointerType, vbo4.BufferTarget, vbo4.Divisor);
            vbos[4] = new GenericVBO(vbo5.ID, attribNames[4], vbo5.Count, vbo5.Size, vbo5.PointerType, vbo5.BufferTarget, vbo5.Divisor);
            vbos[5] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class VAO<T1, T2, T3, T4, T5, T6> : GenericVAO
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, VBO<T2> vbo2, VBO<T3> vbo3, VBO<T4> vbo4, VBO<T5> vbo5, VBO<T6> vbo6, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 6) throw new Exception(string.Format("Expected an array of 6 names, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[7];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(vbo2.ID, attribNames[1], vbo2.Count, vbo2.Size, vbo2.PointerType, vbo2.BufferTarget, vbo2.Divisor);
            vbos[2] = new GenericVBO(vbo3.ID, attribNames[2], vbo3.Count, vbo3.Size, vbo3.PointerType, vbo3.BufferTarget, vbo3.Divisor);
            vbos[3] = new GenericVBO(vbo4.ID, attribNames[3], vbo4.Count, vbo4.Size, vbo4.PointerType, vbo4.BufferTarget, vbo4.Divisor);
            vbos[4] = new GenericVBO(vbo5.ID, attribNames[4], vbo5.Count, vbo5.Size, vbo5.PointerType, vbo5.BufferTarget, vbo5.Divisor);
            vbos[5] = new GenericVBO(vbo6.ID, attribNames[5], vbo6.Count, vbo6.Size, vbo6.PointerType, vbo6.BufferTarget, vbo6.Divisor);
            vbos[6] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class VAO<T1, T2, T3, T4, T5, T6, T7> : GenericVAO
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, VBO<T2> vbo2, VBO<T3> vbo3, VBO<T4> vbo4, VBO<T5> vbo5, VBO<T6> vbo6, VBO<T7> vbo7, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 7) throw new Exception(string.Format("Expected an array of 7 names, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[8];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(vbo2.ID, attribNames[1], vbo2.Count, vbo2.Size, vbo2.PointerType, vbo2.BufferTarget, vbo2.Divisor);
            vbos[2] = new GenericVBO(vbo3.ID, attribNames[2], vbo3.Count, vbo3.Size, vbo3.PointerType, vbo3.BufferTarget, vbo3.Divisor);
            vbos[3] = new GenericVBO(vbo4.ID, attribNames[3], vbo4.Count, vbo4.Size, vbo4.PointerType, vbo4.BufferTarget, vbo4.Divisor);
            vbos[4] = new GenericVBO(vbo5.ID, attribNames[4], vbo5.Count, vbo5.Size, vbo5.PointerType, vbo5.BufferTarget, vbo5.Divisor);
            vbos[5] = new GenericVBO(vbo6.ID, attribNames[5], vbo6.Count, vbo6.Size, vbo6.PointerType, vbo6.BufferTarget, vbo6.Divisor);
            vbos[6] = new GenericVBO(vbo7.ID, attribNames[6], vbo7.Count, vbo7.Size, vbo7.PointerType, vbo7.BufferTarget, vbo7.Divisor);
            vbos[7] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class VAO<T1, T2, T3, T4, T5, T6, T7, T8> : GenericVAO
        where T1 : struct
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
    {
        public VAO(ShaderProgram program, VBO<T1> vbo1, VBO<T2> vbo2, VBO<T3> vbo3, VBO<T4> vbo4, VBO<T5> vbo5, VBO<T6> vbo6, VBO<T7> vbo7, VBO<T8> vbo8, string[] attribNames, VBO<int> elementArray)
            : base(program)
        {
            if (attribNames.Length != 8) throw new Exception(string.Format("Expected an array of 8 names, but instead got {0}.", attribNames.Length));

            GenericVAO.GenericVBO[] vbos = new GenericVBO[8];
            vbos[0] = new GenericVBO(vbo1.ID, attribNames[0], vbo1.Count, vbo1.Size, vbo1.PointerType, vbo1.BufferTarget, vbo1.Divisor);
            vbos[1] = new GenericVBO(vbo2.ID, attribNames[1], vbo2.Count, vbo2.Size, vbo2.PointerType, vbo2.BufferTarget, vbo2.Divisor);
            vbos[2] = new GenericVBO(vbo3.ID, attribNames[2], vbo3.Count, vbo3.Size, vbo3.PointerType, vbo3.BufferTarget, vbo3.Divisor);
            vbos[3] = new GenericVBO(vbo4.ID, attribNames[3], vbo4.Count, vbo4.Size, vbo4.PointerType, vbo4.BufferTarget, vbo4.Divisor);
            vbos[4] = new GenericVBO(vbo5.ID, attribNames[4], vbo5.Count, vbo5.Size, vbo5.PointerType, vbo5.BufferTarget, vbo5.Divisor);
            vbos[5] = new GenericVBO(vbo6.ID, attribNames[5], vbo6.Count, vbo6.Size, vbo6.PointerType, vbo6.BufferTarget, vbo6.Divisor);
            vbos[6] = new GenericVBO(vbo7.ID, attribNames[6], vbo7.Count, vbo7.Size, vbo7.PointerType, vbo7.BufferTarget, vbo7.Divisor);
            vbos[7] = new GenericVBO(vbo8.ID, attribNames[7], vbo8.Count, vbo8.Size, vbo8.PointerType, vbo8.BufferTarget, vbo8.Divisor);
            vbos[8] = new GenericVBO(elementArray.ID, "", elementArray.Count, elementArray.Size, elementArray.PointerType, elementArray.BufferTarget, elementArray.Divisor);

            Init(vbos);
        }
    }

    public class GenericVAO : IDisposable
    {
        #region Generic VBO
        public GenericVBO[] vbos;

        public struct GenericVBO
        {
            public string Name;
            public VertexAttribPointerType PointerType;
            public int Length;
            public BufferTarget BufferTarget;
            public uint ID;
            public int Size;
            public uint Divisor;

#pragma warning disable IDE1006
            [Obsolete("Use Name instead.")]
            public string name
            {
                get { return Name; }
                set { Name = value; }
            }

            [Obsolete("Use PointerType instead.")]
            public VertexAttribPointerType pointerType
            {
                get { return PointerType; }
                set { PointerType = value; }
            }

            [Obsolete("Use Length instead.")]
            public int length
            {
                get { return Length; }
                set { Length = value; }
            }

            [Obsolete("Use BufferTarget instead.")]
            public BufferTarget bufferTarget
            {
                get { return BufferTarget; }
                set { BufferTarget = value; }
            }

            [Obsolete("Use ID instead.")]
            public uint id
            {
                get { return ID; }
                set { ID = value; }
            }

            [Obsolete("Use Size instead.")]
            public int size
            {
                get { return Size; }
                set { Size = value; }
            }
#pragma warning restore

            public GenericVBO(uint id, string name, int length, int size, VertexAttribPointerType pointerType, BufferTarget bufferTarget, uint divisor)
            {
                ID = id;
                Name = name;
                Length = length;
                Size = size;
                PointerType = pointerType;
                BufferTarget = bufferTarget;
                Divisor = divisor;
            }
        }
        #endregion

        #region Constructor and Destructor
        public GenericVAO(ShaderProgram program)
        {
            Program = program;
            DrawMode = BeginMode.Triangles;
        }

        public void Init(GenericVBO[] vbos)
        {
            this.vbos = vbos;

            if (Gl.Version() >= 3)
            {
                ID = Gl.GenVertexArray();
                if (ID != 0)
                {
                    Gl.BindVertexArray(ID);
                    BindAttributes(Program);
                }
                Gl.BindVertexArray(0);

                Draw = DrawOGL3;
                DrawInstanced = DrawInstancedOGL3;
            }
            else
            {
                Draw = DrawOGL2;
                DrawInstanced = DrawInstancedOGL2;
            }
        }

        ~GenericVAO()
        {
            Dispose(false);
        }
        #endregion

        #region Properties
        private bool disposeChildren = false;

        /// <summary>
        /// The number of vertices that make up this VAO.
        /// </summary>
        public int VertexCount { get; set; }

        /// <summary>
        /// Specifies if the VAO should dispose of the child VBOs when Dispose() is called.
        /// </summary>
        public bool DisposeChildren
        {
            get { return disposeChildren; }
            set
            {
                disposeChildren = value;
                DisposeElementArray = value;
            }
        }

        /// <summary>
        /// Specifies if the VAO should dispose of the element array when Dispose() is called.
        /// </summary>
        public bool DisposeElementArray { get; set; }

        /// <summary>
        /// The ShaderProgram associated with this VAO.
        /// </summary>
        public ShaderProgram Program { get; private set; }

        /// <summary>
        /// The drawing mode to use when drawing the arrays.
        /// </summary>
        public BeginMode DrawMode { get; set; }

#pragma warning disable IDE1006
        /// <summary>
        /// The ID of this Vertex Array Object for use in calls to OpenGL.
        /// </summary>
        [Obsolete("Use ID instead.")]
        public uint vaoID
        {
             get { return ID; }
            private set { ID = value; }
        }
#pragma warning restore

        /// <summary>
        /// The ID of this Vertex Array Object for use in calls to OpenGL.
        /// </summary>
        public uint ID { get; private set; }
        #endregion

        #region Draw Methods (OGL2 and OGL3)
        private int SizeOfType(VertexAttribPointerType type)
        {
            switch (type)
            {
                case VertexAttribPointerType.Byte: 
                case VertexAttribPointerType.UnsignedByte: return 1;
                case VertexAttribPointerType.Short:
                case VertexAttribPointerType.UnsignedShort: 
                case VertexAttribPointerType.HalfFloat: return 2;
                case VertexAttribPointerType.Int:
                case VertexAttribPointerType.Float: return 4;
                case VertexAttribPointerType.Double: return 8;
            }
            return 1;
        }

        public void BindAttributes(ShaderProgram program)
        {
            GenericVBO elementArray = new GenericVBO(0, "", 0, 0, VertexAttribPointerType.Byte, BufferTarget.ArrayBuffer, 0);

            for (int i = 0; i < vbos.Length; i++)
            {
                if (vbos[i].BufferTarget == BufferTarget.ElementArrayBuffer)
                {
                    elementArray = vbos[i];
                    continue;
                }

                //According to OGL spec then, if there is no location for an attribute, -1 is returned.
                //The same error representation is used here.
                int loc = program[vbos[i].Name]?.Location ?? -1;
                if (loc == -1) throw new Exception(string.Format("Shader did not contain '{0}'.", vbos[i].Name));

                Gl.EnableVertexAttribArray((uint)loc);
                Gl.BindBuffer(vbos[i].BufferTarget, vbos[i].ID);
                Gl.VertexAttribPointer((uint)loc, vbos[i].Size, vbos[i].PointerType, true, vbos[i].Size * SizeOfType(vbos[i].PointerType), IntPtr.Zero);
                //0 is the divisors default value.
                //No need to set the divisor to its default value.
                if (vbos[i].Divisor != 0)
                {
                    Gl.VertexAttribDivisor((uint)loc, vbos[i].Divisor);
                }
            }

            if (elementArray.ID != 0)
            {
                Gl.BindBuffer(BufferTarget.ElementArrayBuffer, elementArray.ID);
                VertexCount = elementArray.Length;
            }
        }

        public delegate void DrawFunc();
        public delegate void DrawInstancedFunc(int count);

        public DrawFunc Draw;
        public DrawInstancedFunc DrawInstanced;

        /// <summary>
        /// OGL3 method uses a vertex array object for quickly binding the VBOs to their attributes.
        /// </summary>
        private void DrawOGL3()
        {
            if (ID == 0 || VertexCount == 0) return;
            Gl.BindVertexArray(ID);
            Gl.DrawElements(DrawMode, VertexCount, DrawElementsType.UnsignedInt, IntPtr.Zero);
            Gl.BindVertexArray(0);
        }

        /// <summary>
        /// OGL2 does not support VAOs, and instead must bind the VBOs to their attributes manually.
        /// </summary>
        private void DrawOGL2()
        {
            if (VertexCount == 0) return;
            BindAttributes(Program);
            Gl.DrawElements(DrawMode, VertexCount, DrawElementsType.UnsignedInt, IntPtr.Zero);
        }

        /// <summary>
        /// OGL3 method uses a vertex array object for quickly binding the VBOs to their attributes.
        /// </summary>
        private void DrawInstancedOGL3(int count)
        {
            if (ID == 0 || VertexCount == 0 || count == 0) return;
            Gl.BindVertexArray(ID);
            Gl.DrawElementsInstanced(DrawMode, VertexCount, DrawElementsType.UnsignedInt, IntPtr.Zero, count);
            Gl.BindVertexArray(0);
        }

        /// <summary>
        /// OGL2 does not support Gl.DrawElementsInstanced.
        /// </summary>
        private void DrawInstancedOGL2(int count)
        {
            throw new Exception("The Function glDrawElementsInstanced was first added in OpenGL 3.1 which is not supported on this system.");
        }

        /// <summary>
        /// Performs the draw routine with a custom shader program.
        /// </summary>
        /// <param name="program"></param>
        public void DrawProgram(ShaderProgram program)
        {
            BindAttributes(program);
            Gl.DrawElements(DrawMode, VertexCount, DrawElementsType.UnsignedInt, IntPtr.Zero);
        }
        #endregion

        #region IDisposable
        /// <summary>
        /// Deletes the vertex array from the GPU and will also dispose of any child VBOs if (DisposeChildren == true).
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // first try to dispose of the vertex array
            if (ID != 0)
            {
                Gl.DeleteVertexArray(ID);

                ID = 0;
            }

            // children must be disposed of separately since OpenGL 2.1 will not have a vertex array
            if (DisposeChildren)
            {
                for (int i = 0; i < vbos.Length; i++)
                {
                    if (vbos[i].BufferTarget == BufferTarget.ElementArrayBuffer && !DisposeElementArray) continue;
                    Gl.DeleteBuffer(vbos[i].ID);
                }
            }
        }
        #endregion
    }

    public class VAO : IDisposable
    {
        #region Variables
        private VBO<Vector3> vertex, normal, tangent;

        private VBO<Vector2> uv;

        private VBO<int> element;

        private bool disposeChildren = false;
        #endregion

        #region Properties
        /// <summary>
        /// The offset into the element array buffer that this VAO begins.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// The number of vertices that make up this VAO.
        /// </summary>
        public int VertexCount { get; set; }

        /// <summary>
        /// Specifies if the VAO should dispose of the child VBOs when Dispose() is called.
        /// </summary>
        public bool DisposeChildren
        {
            get { return disposeChildren; }
            set
            {
                disposeChildren = value;
                DisposeElementArray = value;
            }
        }

        /// <summary>
        /// Specifies if the VAO should dispose of the element array when Dispose() is called.
        /// </summary>
        public bool DisposeElementArray { get; set; }

        /// <summary>
        /// The ShaderProgram associated with this VAO.
        /// </summary>
        public ShaderProgram Program { get; private set; }

        /// <summary>
        /// The drawing mode to use when drawing the arrays.
        /// </summary>
        public BeginMode DrawMode { get; set; }

#pragma warning disable IDE1006
        /// <summary>
        /// The ID of this Vertex Array Object for use in calls to OpenGL.
        /// </summary>
        [Obsolete("Use ID instead.")]
        public uint vaoID
        {
            get { return ID; }
            private set { ID = value; }
        }
#pragma warning restore

        /// <summary>
        /// The ID of this Vertex Array Object for use in calls to OpenGL.
        /// </summary>
        public uint ID { get; private set; }
        #endregion

        #region Constructors and Destructor
        public VAO(ShaderProgram program, VBO<Vector3> vertex, VBO<int> element)
            : this(program, vertex, null, null, null, element)
        {
        }

        public VAO(ShaderProgram program, VBO<Vector3> vertex, VBO<Vector2> uv, VBO<int> element)
            : this(program, vertex, null, null, uv, element)
        {
        }

        public VAO(ShaderProgram program, VBO<Vector3> vertex, VBO<Vector3> normal, VBO<int> element)
            : this(program, vertex, normal, null, null, element)
        {
        }

        public VAO(ShaderProgram program, VBO<Vector3> vertex, VBO<Vector3> normal, VBO<Vector2> uv, VBO<int> element)
            : this(program, vertex, normal, null, uv, element)
        {
        }

        public VAO(ShaderProgram program, VBO<Vector3> vertex, VBO<Vector3> normal, VBO<Vector3> tangent, VBO<Vector2> uv, VBO<int> element)
        {
            Program = program;
            VertexCount = element.Count;
            DrawMode = BeginMode.Triangles;

            this.vertex = vertex;
            this.normal = normal;
            this.tangent = tangent;
            this.uv = uv;
            this.element = element;

            if (Gl.Version() >= 3)
            {
                ID = Gl.GenVertexArray();
                if (ID != 0)
                {
                    Gl.BindVertexArray(ID);
                    BindAttributes(Program);
                }
                Gl.BindVertexArray(0);

                Draw = DrawOGL3;
            }
            else
            {
                Draw = DrawOGL2;
            }
        }

        ~VAO()
        {
            Dispose(false);
        }
        #endregion

        #region Draw Methods (OGL2 and OGL3)
        public void BindCachedAttributes(ShaderProgram program, int vertexAttributeLocation, int normalAttributeLocation = -1, int uvAttributeLocation = -1, int tangentAttributeLocation = -1)
        {
            if (normalAttributeLocation != -1 && normal.ID != 0)
            {
                Gl.EnableVertexAttribArray((uint)normalAttributeLocation);
                Gl.BindBuffer(normal.BufferTarget, normal.ID);
                Gl.VertexAttribPointer((uint)normalAttributeLocation, normal.Size, normal.PointerType, true, 12, IntPtr.Zero);
            }

            if (uvAttributeLocation != -1 && uv.ID != 0)
            {
                Gl.EnableVertexAttribArray((uint)uvAttributeLocation);
                Gl.BindBuffer(uv.BufferTarget, uv.ID);
                Gl.VertexAttribPointer((uint)uvAttributeLocation, uv.Size, uv.PointerType, true, 8, IntPtr.Zero);
            }

            if (tangentAttributeLocation != -1 && tangent.ID != 0)
            {
                Gl.EnableVertexAttribArray((uint)tangentAttributeLocation);
                Gl.BindBuffer(tangent.BufferTarget, tangent.ID);
                Gl.VertexAttribPointer((uint)tangentAttributeLocation, tangent.Size, tangent.PointerType, true, 12, IntPtr.Zero);
            }

            BindCachedAttributes(vertexAttributeLocation, program);
        }

        public void BindCachedAttributes(int vertexAttributeLocation, ShaderProgram program)
        {
            if (vertex == null || vertex.ID == 0) throw new Exception("Error binding attributes.  No vertices were supplied.");
            if (element == null || element.ID == 0) throw new Exception("Error binding attributes.  No element array was supplied.");

            Gl.EnableVertexAttribArray((uint)vertexAttributeLocation);
            Gl.BindBuffer(vertex.BufferTarget, vertex.ID);
            Gl.VertexAttribPointer((uint)vertexAttributeLocation, vertex.Size, vertex.PointerType, true, 12, IntPtr.Zero);

            Gl.BindBuffer(BufferTarget.ElementArrayBuffer, element.ID);
        }

        /// <summary>
        /// Generic method for binding the VBOs to their respective attribute locations.
        /// </summary>
        /// <param name="program">The shader program to bind attributes to.</param>
        /// <param name="positionName">The attribute name for the vertex positions.</param>
        /// <param name="normalName">The attribute naem for the vertex normals.</param>
        /// <param name="uvName">The attribute name for the vertex UV co-ordinates.</param>
        /// <param name="tangentName">The attribute name for the vertex tangents.</param>
        public void BindAttributes(ShaderProgram program, string positionName = "in_position", string normalName = "in_normal", string uvName = "in_uv", string tangentName = "in_tangent")
        {
            if (vertex == null || vertex.ID == 0) throw new Exception("Error binding attributes.  No vertices were supplied.");
            if (element == null || element.ID == 0) throw new Exception("Error binding attributes.  No element array was supplied.");

            // Note:  Since the shader is already compiled, we cannot set the attribute locations.
            //  Instead we must query the shader for the locations that the linker chose and use them.
            int loc = Gl.GetAttribLocation(program.ProgramID, positionName);
            if (loc == -1) throw new Exception("Shader did not contain '" + positionName + "'.");

            Gl.EnableVertexAttribArray((uint)loc);
            Gl.BindBuffer(vertex.BufferTarget, vertex.ID);
            Gl.VertexAttribPointer((uint)loc, vertex.Size, vertex.PointerType, true, 12, IntPtr.Zero);

            if (normal != null && normal.ID != 0)
            {
                loc = Gl.GetAttribLocation(program.ProgramID, normalName);
                if (loc != -1)
                {
                    Gl.EnableVertexAttribArray((uint)loc);
                    Gl.BindBuffer(normal.BufferTarget, normal.ID);
                    Gl.VertexAttribPointer((uint)loc, normal.Size, normal.PointerType, true, 12, IntPtr.Zero);
                }
            }

            if (uv != null && uv.ID != 0)
            {
                loc = Gl.GetAttribLocation(program.ProgramID, uvName);
                if (loc != -1)
                {
                    Gl.EnableVertexAttribArray((uint)loc);
                    Gl.BindBuffer(uv.BufferTarget, uv.ID);
                    Gl.VertexAttribPointer((uint)loc, uv.Size, uv.PointerType, true, 8, IntPtr.Zero);
                }
            }

            if (tangent != null && tangent.ID != 0)
            {
                loc = Gl.GetAttribLocation(program.ProgramID, tangentName);
                if (loc != -1)
                {
                    Gl.EnableVertexAttribArray((uint)loc);
                    Gl.BindBuffer(tangent.BufferTarget, tangent.ID);
                    Gl.VertexAttribPointer((uint)loc, tangent.Size, tangent.PointerType, true, 12, IntPtr.Zero);
                }
            }

            Gl.BindBuffer(BufferTarget.ElementArrayBuffer, element.ID);
        }

        public delegate void DrawFunc();

        public DrawFunc Draw;

        /// <summary>
        /// OGL3 method uses a vertex array object for quickly binding the VBOs to their attributes.
        /// </summary>
        private void DrawOGL3()
        {
            if (ID == 0) return;
            Gl.BindVertexArray(ID);

            IntPtr offset = (IntPtr)(Offset * 4);
            Gl.DrawElements(DrawMode, VertexCount, DrawElementsType.UnsignedInt, offset);

            Gl.BindVertexArray(0);
        }

        /// <summary>
        /// OGL2 does not support VAOs, and instead must bind the VBOs to their attributes manually.
        /// </summary>
        private void DrawOGL2()
        {
            BindAttributes(Program);

            IntPtr offset = (IntPtr)(Offset * 4);
            Gl.DrawElements(DrawMode, VertexCount, DrawElementsType.UnsignedInt, offset);
        }

        /// <summary>
        /// Performs the draw routine with a custom shader program.
        /// </summary>
        /// <param name="program"></param>
        public void DrawProgram(ShaderProgram program)
        {
            BindAttributes(program);
            if (Offset == 0) Gl.DrawElements(DrawMode, VertexCount, DrawElementsType.UnsignedInt, IntPtr.Zero);
            else Gl.DrawElementsBaseVertex(DrawMode, VertexCount, DrawElementsType.UnsignedInt, IntPtr.Zero, Offset);
        }
        #endregion

        #region IDisposable
        /// <summary>
        /// Deletes the vertex array from the GPU and will also dispose of any child VBOs if (DisposeChildren == true).
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            // first try to dispose of the vertex array
            if (ID != 0)
            {
                Gl.DeleteVertexArray(ID);

                ID = 0;
            }

            // children must be disposed of separately since OpenGL 2.1 will not have a vertex array
            if (DisposeChildren)
            {
                if (vertex != null) vertex.Dispose();
                if (normal != null) normal.Dispose();
                if (tangent != null) tangent.Dispose();
                if (uv != null) uv.Dispose();
                if (element != null && DisposeElementArray) element.Dispose();

                vertex = null;
                normal = null;
                tangent = null;
                uv = null;
                element = null;
            }
        }
        #endregion
    }
}
