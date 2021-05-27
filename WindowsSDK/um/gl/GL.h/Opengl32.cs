using System;
using System.Runtime.InteropServices;

namespace Antrv.Interop.WindowsSDK
{
    /// <summary>
    /// Procedure declarations, constant definitions and macros for the OpenGL component.
    /// </summary>
    public static class Opengl32
    {
        public const string LibraryName = "opengl32";

        [DllImport(LibraryName)]
        public static extern void glAccum(GLenum op, float value);

        [DllImport(LibraryName)]
        public static extern void glAlphaFunc(GLenum func, float @ref);

        [DllImport(LibraryName)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool glAreTexturesResident(int n, Ptr<uint> textures, Ptr<bool> residences);

        [DllImport(LibraryName)]
        public static extern void glArrayElement(int i);

        [DllImport(LibraryName)]
        public static extern void glBegin(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glBindTexture(GLenum target, uint texture);

        [DllImport(LibraryName)]
        public static extern void glBitmap(int width, int height, float xorig, float yorig, float xmove,
            float ymove, Ptr<byte> bitmap);

        [DllImport(LibraryName)]
        public static extern void glBlendFunc(GLenum sfactor, GLenum dfactor);

        [DllImport(LibraryName)]
        public static extern void glCallList(uint list);

        [DllImport(LibraryName)]
        public static extern void glCallLists(int n, GLenum type, IntPtr lists);

        [DllImport(LibraryName)]
        public static extern void glClear(uint mask);

        [DllImport(LibraryName)]
        public static extern void glClearAccum(float red, float green, float blue, float alpha);

        [DllImport(LibraryName)]
        public static extern void glClearColor(float red, float green, float blue, float alpha);

        [DllImport(LibraryName)]
        public static extern void glClearDepth(double depth);

        [DllImport(LibraryName)]
        public static extern void glClearIndex(float c);

        [DllImport(LibraryName)]
        public static extern void glClearStencil(int s);

        [DllImport(LibraryName)]
        public static extern void glClipPlane(GLenum plane, Ptr<double> equation);

        [DllImport(LibraryName)]
        public static extern void glColor3b(sbyte red, sbyte green, sbyte blue);

        [DllImport(LibraryName)]
        public static extern void glColor3bv(Ptr<sbyte> v);

        [DllImport(LibraryName)]
        public static extern void glColor3d(double red, double green, double blue);

        [DllImport(LibraryName)]
        public static extern void glColor3dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glColor3f(float red, float green, float blue);

        [DllImport(LibraryName)]
        public static extern void glColor3fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glColor3i(int red, int green, int blue);

        [DllImport(LibraryName)]
        public static extern void glColor3iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glColor3s(short red, short green, short blue);

        [DllImport(LibraryName)]
        public static extern void glColor3sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glColor3ub(byte red, byte green, byte blue);

        [DllImport(LibraryName)]
        public static extern void glColor3ubv(Ptr<byte> v);

        [DllImport(LibraryName)]
        public static extern void glColor3ui(uint red, uint green, uint blue);

        [DllImport(LibraryName)]
        public static extern void glColor3uiv(Ptr<uint> v);

        [DllImport(LibraryName)]
        public static extern void glColor3us(ushort red, ushort green, ushort blue);

        [DllImport(LibraryName)]
        public static extern void glColor3usv(Ptr<ushort> v);

        [DllImport(LibraryName)]
        public static extern void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4bv(Ptr<sbyte> v);

        [DllImport(LibraryName)]
        public static extern void glColor4d(double red, double green, double blue, double alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glColor4f(float red, float green, float blue, float alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glColor4i(int red, int green, int blue, int alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glColor4s(short red, short green, short blue, short alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glColor4ub(byte red, byte green, byte blue, byte alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4ubv(Ptr<byte> v);

        [DllImport(LibraryName)]
        public static extern void glColor4ui(uint red, uint green, uint blue, uint alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4uiv(Ptr<uint> v);

        [DllImport(LibraryName)]
        public static extern void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);

        [DllImport(LibraryName)]
        public static extern void glColor4usv(Ptr<ushort> v);

        [DllImport(LibraryName)]
        public static extern void glColorMask([MarshalAs(UnmanagedType.U1)] bool red,
            [MarshalAs(UnmanagedType.U1)] bool green, [MarshalAs(UnmanagedType.U1)] bool blue,
            [MarshalAs(UnmanagedType.U1)] bool alpha);

        [DllImport(LibraryName)]
        public static extern void glColorMaterial(GLenum face, GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glColorPointer(int size, GLenum type, int stride, IntPtr pointer);

        [DllImport(LibraryName)]
        public static extern void glCopyPixels(int x, int y, int width, int height, GLenum type);

        [DllImport(LibraryName)]
        public static extern void glCopyTexImage1D(GLenum target, int level, GLenum internalFormat, int x, int y,
            int width, int border);

        [DllImport(LibraryName)]
        public static extern void glCopyTexImage2D(GLenum target, int level, GLenum internalFormat, int x, int y,
            int width, int height, int border);

        [DllImport(LibraryName)]
        public static extern void glCopyTexSubImage1D(GLenum target, int level, int xoffset, int x, int y,
            int width);

        [DllImport(LibraryName)]
        public static extern void glCopyTexSubImage2D(GLenum target, int level, int xoffset, int yoffset, int x,
            int y, int width, int height);

        [DllImport(LibraryName)]
        public static extern void glCullFace(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glDeleteLists(uint list, int range);

        [DllImport(LibraryName)]
        public static extern void glDeleteTextures(int n, Ptr<uint> textures);

        [DllImport(LibraryName)]
        public static extern void glDepthFunc(GLenum func);

        [DllImport(LibraryName)]
        public static extern void glDepthMask([MarshalAs(UnmanagedType.U1)] bool flag);

        [DllImport(LibraryName)]
        public static extern void glDepthRange(double zNear, double zFar);

        [DllImport(LibraryName)]
        public static extern void glDisable(GLenum cap);

        [DllImport(LibraryName)]
        public static extern void glDisableClientState(GLenum array);

        [DllImport(LibraryName)]
        public static extern void glDrawArrays(GLenum mode, int first, int count);

        [DllImport(LibraryName)]
        public static extern void glDrawBuffer(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glDrawElements(GLenum mode, int count, GLenum type, IntPtr indices);

        [DllImport(LibraryName)]
        public static extern void glDrawPixels(int width, int height, GLenum format, GLenum type, IntPtr pixels);

        [DllImport(LibraryName)]
        public static extern void glEdgeFlag([MarshalAs(UnmanagedType.U1)] bool flag);

        [DllImport(LibraryName)]
        public static extern void glEdgeFlagPointer(int stride, IntPtr pointer);

        [DllImport(LibraryName)]
        public static extern void glEdgeFlagv(Ptr<bool> flag);

        [DllImport(LibraryName)]
        public static extern void glEnable(GLenum cap);

        [DllImport(LibraryName)]
        public static extern void glEnableClientState(GLenum array);

        [DllImport(LibraryName)]
        public static extern void glEnd();

        [DllImport(LibraryName)]
        public static extern void glEndList();

        [DllImport(LibraryName)]
        public static extern void glEvalCoord1d(double u);

        [DllImport(LibraryName)]
        public static extern void glEvalCoord1dv(Ptr<double> u);

        [DllImport(LibraryName)]
        public static extern void glEvalCoord1f(float u);

        [DllImport(LibraryName)]
        public static extern void glEvalCoord1fv(Ptr<float> u);

        [DllImport(LibraryName)]
        public static extern void glEvalCoord2d(double u, double v);

        [DllImport(LibraryName)]
        public static extern void glEvalCoord2dv(Ptr<double> u);

        [DllImport(LibraryName)]
        public static extern void glEvalCoord2f(float u, float v);

        [DllImport(LibraryName)]
        public static extern void glEvalCoord2fv(Ptr<float> u);

        [DllImport(LibraryName)]
        public static extern void glEvalMesh1(GLenum mode, int i1, int i2);

        [DllImport(LibraryName)]
        public static extern void glEvalMesh2(GLenum mode, int i1, int i2, int j1, int j2);

        [DllImport(LibraryName)]
        public static extern void glEvalPoint1(int i);

        [DllImport(LibraryName)]
        public static extern void glEvalPoint2(int i, int j);

        [DllImport(LibraryName)]
        public static extern void glFeedbackBuffer(int size, GLenum type, Ptr<float> buffer);

        [DllImport(LibraryName)]
        public static extern void glFinish();

        [DllImport(LibraryName)]
        public static extern void glFlush();

        [DllImport(LibraryName)]
        public static extern void glFogf(GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glFogfv(GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glFogi(GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glFogiv(GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glFrontFace(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glFrustum(double left, double right, double bottom, double top,
            double zNear, double zFar);

        [DllImport(LibraryName)]
        public static extern uint glGenLists(int range);

        [DllImport(LibraryName)]
        public static extern void glGenTextures(int n, Ptr<uint> textures);

        [DllImport(LibraryName)]
        public static extern void glGetBooleanv(GLenum pname, Ptr<bool> @params);

        [DllImport(LibraryName)]
        public static extern void glGetClipPlane(GLenum plane, Ptr<double> equation);

        [DllImport(LibraryName)]
        public static extern void glGetDoublev(GLenum pname, Ptr<double> @params);

        [DllImport(LibraryName)]
        public static extern GLenum glGetError();

        [DllImport(LibraryName)]
        public static extern void glGetFloatv(GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glGetIntegerv(GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glGetLightfv(GLenum light, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glGetLightiv(GLenum light, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glGetMapdv(GLenum target, GLenum query, Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glGetMapfv(GLenum target, GLenum query, Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glGetMapiv(GLenum target, GLenum query, Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glGetMaterialfv(GLenum face, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glGetMaterialiv(GLenum face, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glGetPixelMapfv(GLenum map, Ptr<float> values);

        [DllImport(LibraryName)]
        public static extern void glGetPixelMapuiv(GLenum map, Ptr<uint> values);

        [DllImport(LibraryName)]
        public static extern void glGetPixelMapusv(GLenum map, Ptr<ushort> values);

        [DllImport(LibraryName)]
        public static extern void glGetPointerv(GLenum pname, Ptr<IntPtr> @params);

        [DllImport(LibraryName)]
        public static extern void glGetPolygonStipple(Ptr<byte> mask);

        [DllImport(LibraryName)]
        public static extern Ptr<byte> glGetString(GLenum name);

        [DllImport(LibraryName)]
        public static extern void glGetTexEnvfv(GLenum target, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glGetTexEnviv(GLenum target, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glGetTexGendv(GLenum coord, GLenum pname, Ptr<double> @params);

        [DllImport(LibraryName)]
        public static extern void glGetTexGenfv(GLenum coord, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glGetTexGeniv(GLenum coord, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glGetTexImage(GLenum target, int level, GLenum format, GLenum type, IntPtr pixels);

        [DllImport(LibraryName)]
        public static extern void glGetTexLevelParameterfv(GLenum target, int level, GLenum pname,
            Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void
            glGetTexLevelParameteriv(GLenum target, int level, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glGetTexParameterfv(GLenum target, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glGetTexParameteriv(GLenum target, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glHint(GLenum target, GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glIndexMask(uint mask);

        [DllImport(LibraryName)]
        public static extern void glIndexPointer(GLenum type, int stride, IntPtr pointer);

        [DllImport(LibraryName)]
        public static extern void glIndexd(double c);

        [DllImport(LibraryName)]
        public static extern void glIndexdv(Ptr<double> c);

        [DllImport(LibraryName)]
        public static extern void glIndexf(float c);

        [DllImport(LibraryName)]
        public static extern void glIndexfv(Ptr<float> c);

        [DllImport(LibraryName)]
        public static extern void glIndexi(int c);

        [DllImport(LibraryName)]
        public static extern void glIndexiv(Ptr<int> c);

        [DllImport(LibraryName)]
        public static extern void glIndexs(short c);

        [DllImport(LibraryName)]
        public static extern void glIndexsv(Ptr<short> c);

        [DllImport(LibraryName)]
        public static extern void glIndexub(byte c);

        [DllImport(LibraryName)]
        public static extern void glIndexubv(Ptr<byte> c);

        [DllImport(LibraryName)]
        public static extern void glInitNames();

        [DllImport(LibraryName)]
        public static extern void interleavedArrays(GLenum format, int stride, IntPtr pointer);

        [DllImport(LibraryName)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool glIsEnabled(GLenum cap);

        [DllImport(LibraryName)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool glIsList(uint list);

        [DllImport(LibraryName)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool glIsTexture(uint texture);

        [DllImport(LibraryName)]
        public static extern void glLightModelf(GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glLightModelfv(GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glLightModeli(GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glLightModeliv(GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glLightf(GLenum light, GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glLightfv(GLenum light, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glLighti(GLenum light, GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glLightiv(GLenum light, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glLineStipple(int factor, ushort pattern);

        [DllImport(LibraryName)]
        public static extern void glLineWidth(float width);

        [DllImport(LibraryName)]
        public static extern void glListBase(uint @base);

        [DllImport(LibraryName)]
        public static extern void glLoadIdentity();

        [DllImport(LibraryName)]
        public static extern void glLoadMatrixd(Ptr<double> m);

        [DllImport(LibraryName)]
        public static extern void glLoadMatrixf(Ptr<float> m);

        [DllImport(LibraryName)]
        public static extern void glLoadName(uint name);

        [DllImport(LibraryName)]
        public static extern void glLogicOp(GLenum opcode);

        [DllImport(LibraryName)]
        public static extern void glMap1d(GLenum target, double u1, double u2, int stride, int order,
            Ptr<double> points);

        [DllImport(LibraryName)]
        public static extern void glMap1f(GLenum target, float u1, float u2, int stride, int order,
            Ptr<float> points);

        [DllImport(LibraryName)]
        public static extern void glMap2d(GLenum target, double u1, double u2, int ustride, int uorder,
            double v1, double v2, int vstride, int vorder, Ptr<double> points);

        [DllImport(LibraryName)]
        public static extern void glMap2f(GLenum target, float u1, float u2, int ustride, int uorder,
            float v1, float v2, int vstride, int vorder, Ptr<float> points);

        [DllImport(LibraryName)]
        public static extern void glMapGrid1d(int un, double u1, double u2);

        [DllImport(LibraryName)]
        public static extern void glMapGrid1f(int un, float u1, float u2);

        [DllImport(LibraryName)]
        public static extern void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

        [DllImport(LibraryName)]
        public static extern void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

        [DllImport(LibraryName)]
        public static extern void glMaterialf(GLenum face, GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glMaterialfv(GLenum face, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glMateriali(GLenum face, GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glMaterialiv(GLenum face, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glMatrixMode(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glMultMatrixd(Ptr<double> m);

        [DllImport(LibraryName)]
        public static extern void glMultMatrixf(Ptr<float> m);

        [DllImport(LibraryName)]
        public static extern void glNewList(uint list, GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

        [DllImport(LibraryName)]
        public static extern void glNormal3bv(Ptr<sbyte> v);

        [DllImport(LibraryName)]
        public static extern void glNormal3d(double nx, double ny, double nz);

        [DllImport(LibraryName)]
        public static extern void glNormal3dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glNormal3f(float nx, float ny, float nz);

        [DllImport(LibraryName)]
        public static extern void glNormal3fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glNormal3i(int nx, int ny, int nz);

        [DllImport(LibraryName)]
        public static extern void glNormal3iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glNormal3s(short nx, short ny, short nz);

        [DllImport(LibraryName)]
        public static extern void glNormal3sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glNormalPointer(GLenum type, int stride, IntPtr pointer);

        [DllImport(LibraryName)]
        public static extern void glOrtho(double left, double right, double bottom, double top, double zNear,
            double zFar);

        [DllImport(LibraryName)]
        public static extern void glPassThrough(float token);

        [DllImport(LibraryName)]
        public static extern void glPixelMapfv(GLenum map, int mapsize, Ptr<float> values);

        [DllImport(LibraryName)]
        public static extern void glPixelMapuiv(GLenum map, int mapsize, Ptr<uint> values);

        [DllImport(LibraryName)]
        public static extern void glPixelMapusv(GLenum map, int mapsize, Ptr<ushort> values);

        [DllImport(LibraryName)]
        public static extern void glPixelStoref(GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glPixelStorei(GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glPixelTransferf(GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glPixelTransferi(GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glPixelZoom(float xfactor, float yfactor);

        [DllImport(LibraryName)]
        public static extern void glPointSize(float size);

        [DllImport(LibraryName)]
        public static extern void glPolygonMode(GLenum face, GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glPolygonOffset(float factor, float units);

        [DllImport(LibraryName)]
        public static extern void glPolygonStipple(Ptr<byte> mask);

        [DllImport(LibraryName)]
        public static extern void glPopAttrib();

        [DllImport(LibraryName)]
        public static extern void glPopClientAttrib();

        [DllImport(LibraryName)]
        public static extern void glPopMatrix();

        [DllImport(LibraryName)]
        public static extern void glPopName();

        [DllImport(LibraryName)]
        public static extern void glPrioritizeTextures(int n, Ptr<uint> textures, Ptr<float> priorities);

        [DllImport(LibraryName)]
        public static extern void glPushAttrib(uint mask);

        [DllImport(LibraryName)]
        public static extern void glPushClientAttrib(uint mask);

        [DllImport(LibraryName)]
        public static extern void glPushMatrix();

        [DllImport(LibraryName)]
        public static extern void glPushName(uint name);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2d(double x, double y);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2f(float x, float y);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2i(int x, int y);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2s(short x, short y);

        [DllImport(LibraryName)]
        public static extern void glRasterPos2sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3d(double x, double y, double z);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3f(float x, float y, float z);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3i(int x, int y, int z);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3s(short x, short y, short z);

        [DllImport(LibraryName)]
        public static extern void glRasterPos3sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4d(double x, double y, double z, double w);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4f(float x, float y, float z, float w);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4i(int x, int y, int z, int w);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4s(short x, short y, short z, short w);

        [DllImport(LibraryName)]
        public static extern void glRasterPos4sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glReadBuffer(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glReadPixels(int x, int y, int width, int height, GLenum format,
            GLenum type, IntPtr pixels);

        [DllImport(LibraryName)]
        public static extern void glRectd(double x1, double y1, double x2, double y2);

        [DllImport(LibraryName)]
        public static extern void glRectdv(Ptr<double> v1, Ptr<double> v2);

        [DllImport(LibraryName)]
        public static extern void glRectf(float x1, float y1, float x2, float y2);

        [DllImport(LibraryName)]
        public static extern void glRectfv(Ptr<float> v1, Ptr<float> v2);

        [DllImport(LibraryName)]
        public static extern void glRecti(int x1, int y1, int x2, int y2);

        [DllImport(LibraryName)]
        public static extern void glRectiv(Ptr<int> v1, Ptr<int> v2);

        [DllImport(LibraryName)]
        public static extern void glRects(short x1, short y1, short x2, short y2);

        [DllImport(LibraryName)]
        public static extern void glRectsv(Ptr<short> v1, Ptr<short> v2);

        [DllImport(LibraryName)]
        public static extern int glRenderMode(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glRotated(double angle, double x, double y, double z);

        [DllImport(LibraryName)]
        public static extern void glRotatef(float angle, float x, float y, float z);

        [DllImport(LibraryName)]
        public static extern void glScaled(double x, double y, double z);

        [DllImport(LibraryName)]
        public static extern void glScalef(float x, float y, float z);

        [DllImport(LibraryName)]
        public static extern void glScissor(int x, int y, int width, int height);

        [DllImport(LibraryName)]
        public static extern void glSelectBuffer(int size, Ptr<uint> buffer);

        [DllImport(LibraryName)]
        public static extern void glShadeModel(GLenum mode);

        [DllImport(LibraryName)]
        public static extern void glStencilFunc(GLenum func, int @ref, uint mask);

        [DllImport(LibraryName)]
        public static extern void glStencilMask(uint mask);

        [DllImport(LibraryName)]
        public static extern void glStencilOp(GLenum fail, GLenum zfail, GLenum zpass);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1d(double s);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1f(float s);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1i(int s);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1s(short s);

        [DllImport(LibraryName)]
        public static extern void glTexCoord1sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2d(double s, double t);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2f(float s, float t);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2i(int s, int t);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2s(short s, short t);

        [DllImport(LibraryName)]
        public static extern void glTexCoord2sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3d(double s, double t, double r);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3f(float s, float t, float r);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3i(int s, int t, int r);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3s(short s, short t, short r);

        [DllImport(LibraryName)]
        public static extern void glTexCoord3sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4d(double s, double t, double r, double q);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4f(float s, float t, float r, float q);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4i(int s, int t, int r, int q);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4s(short s, short t, short r, short q);

        [DllImport(LibraryName)]
        public static extern void glTexCoord4sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glTexCoordPointer(int size, GLenum type, int stride, IntPtr pointer);

        [DllImport(LibraryName)]
        public static extern void glTexEnvf(GLenum target, GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glTexEnvfv(GLenum target, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glTexEnvi(GLenum target, GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glTexEnviv(GLenum target, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glTexGend(GLenum coord, GLenum pname, double param);

        [DllImport(LibraryName)]
        public static extern void glTexGendv(GLenum coord, GLenum pname, Ptr<double> @params);

        [DllImport(LibraryName)]
        public static extern void glTexGenf(GLenum coord, GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glTexGenfv(GLenum coord, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glTexGeni(GLenum coord, GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glTexGeniv(GLenum coord, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glTexImage1D(GLenum target, int level, int internalformat, int width,
            int border, GLenum format, GLenum type, IntPtr pixels);

        [DllImport(LibraryName)]
        public static extern void glTexImage2D(GLenum target, int level, int internalformat, int width,
            int height, int border, GLenum format, GLenum type, IntPtr pixels);

        [DllImport(LibraryName)]
        public static extern void glTexParameterf(GLenum target, GLenum pname, float param);

        [DllImport(LibraryName)]
        public static extern void glTexParameterfv(GLenum target, GLenum pname, Ptr<float> @params);

        [DllImport(LibraryName)]
        public static extern void glTexParameteri(GLenum target, GLenum pname, int param);

        [DllImport(LibraryName)]
        public static extern void glTexParameteriv(GLenum target, GLenum pname, Ptr<int> @params);

        [DllImport(LibraryName)]
        public static extern void glTexSubImage1D(GLenum target, int level, int xoffset, int width,
            GLenum format, GLenum type, IntPtr pixels);

        [DllImport(LibraryName)]
        public static extern void glTexSubImage2D(GLenum target, int level, int xoffset, int yoffset,
            int width, int height, GLenum format, GLenum type, IntPtr pixels);

        [DllImport(LibraryName)]
        public static extern void glTranslated(double x, double y, double z);

        [DllImport(LibraryName)]
        public static extern void glTranslatef(float x, float y, float z);

        [DllImport(LibraryName)]
        public static extern void glVertex2d(double x, double y);

        [DllImport(LibraryName)]
        public static extern void glVertex2dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glVertex2f(float x, float y);

        [DllImport(LibraryName)]
        public static extern void glVertex2fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glVertex2i(int x, int y);

        [DllImport(LibraryName)]
        public static extern void glVertex2iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glVertex2s(short x, short y);

        [DllImport(LibraryName)]
        public static extern void glVertex2sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glVertex3d(double x, double y, double z);

        [DllImport(LibraryName)]
        public static extern void glVertex3dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glVertex3f(float x, float y, float z);

        [DllImport(LibraryName)]
        public static extern void glVertex3fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glVertex3i(int x, int y, int z);

        [DllImport(LibraryName)]
        public static extern void glVertex3iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glVertex3s(short x, short y, short z);

        [DllImport(LibraryName)]
        public static extern void glVertex3sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glVertex4d(double x, double y, double z, double w);

        [DllImport(LibraryName)]
        public static extern void glVertex4dv(Ptr<double> v);

        [DllImport(LibraryName)]
        public static extern void glVertex4f(float x, float y, float z, float w);

        [DllImport(LibraryName)]
        public static extern void glVertex4fv(Ptr<float> v);

        [DllImport(LibraryName)]
        public static extern void glVertex4i(int x, int y, int z, int w);

        [DllImport(LibraryName)]
        public static extern void glVertex4iv(Ptr<int> v);

        [DllImport(LibraryName)]
        public static extern void glVertex4s(short x, short y, short z, short w);

        [DllImport(LibraryName)]
        public static extern void glVertex4sv(Ptr<short> v);

        [DllImport(LibraryName)]
        public static extern void glVertexPointer(int size, GLenum type, int stride, IntPtr pointer);

        [DllImport(LibraryName)]
        public static extern void glViewport(int x, int y, int width, int height);
    }
}
