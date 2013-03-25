namespace UnstoppableMickey
{
    using System;
    using System.Collections.Generic;

    public interface IVisualizer
    {
        void Visualize(GameObject obj);

        void VisualizeText(TextObject obj);

        void EndOfGame();

        void Clear(List<GameObject> objects);
    }
}
