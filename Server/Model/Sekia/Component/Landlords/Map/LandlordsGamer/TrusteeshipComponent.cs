﻿namespace ETModel
{
    /// <summary>
    /// 托管组件，逻辑在TrusteeshipComponentSystem扩展
    /// </summary>
    public class TrusteeshipComponent : Component
    {
        public override void Dispose()
        {
            if(this.IsDisposed)
            {
                return;
            }

            base.Dispose();
        }
    }
}
