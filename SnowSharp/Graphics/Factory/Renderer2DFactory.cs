﻿namespace SnowSharp.Graphics.Factory
{

    /// <summary>
    /// 2D渲染器工厂
    /// </summary>
    public abstract class Renderer2DFactory
    {

        /// <summary>
        /// 创建不经常变动的DrawCall
        /// </summary>
        /// <returns>DrawCall</returns>
        public abstract Renderer2D.IDrawCall2D CreateDrawCallStatic();


        /// <summary>
        /// 创建经常变动的DrawCall
        /// </summary>
        /// <returns>DrawCall</returns>
        public abstract Renderer2D.IDrawCall2D CreateDrawCallDymic();


        /// <summary>
        /// 创建材质加载器
        /// </summary>
        /// <returns>材质加载器对象</returns>
        public abstract IMateria2DLoader CreateMateriaLoader();


        /// <summary>
        /// 创建2D渲染队列
        /// </summary>
        /// <returns>渲染队列对象</returns>
        public abstract Renderer2D.RendererQueue2D CreateRendererQueue();
    }
}
