﻿namespace ABCNET.Extensions
{
    /// <summary>
    /// Результат для Associate.
    /// </summary>
    public class AssociateRes<T, TOutput>
    {
        /// <summary>
        /// Элемент.
        /// </summary>
        public T Item { get; }

        /// <summary>
        /// Проекция элемента.
        /// </summary>
        public TOutput Projection { get; }

        /// <summary>
        /// Конструктор для AssociateRes.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <param name="projection">Проекция элемента.</param>
        public AssociateRes(T item, TOutput projection)
        {
            Item = item;
            Projection = projection;
        }

        /// <summary>
        /// Деконструктор для AssociateRes.
        /// </summary>
        /// <param name="item">Элемент.</param>
        /// <param name="projection">Проекция элемента.</param>
        public void Deconstruct(out T item, out TOutput projection)
        {
            item = Item;
            projection = Projection;
        }

        /// <summary>
        /// Метод для преобразования в строку.
        /// </summary>
        public override string ToString()
        {
            return $"[{Item.NilOrString()} - {Projection.NilOrString()}]";
        }
    }
}