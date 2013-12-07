using MagesAssembly.Core.Effects;
using MagesAssembly.Core.EventSystem;
using System;
using System.Windows.Forms;
using MyEventManager = MagesAssembly.Core.EventSystem.EventManager;

namespace MagesAssembly.Tests.EventManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyEventManager.Instance.Subscribe<BaseEvent>(new BaseEffect());
            MyEventManager.Instance.Subscribe<SuperEvent>(new SuperEffect());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyEventManager.Instance.Publish(new SuperEvent());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyEventManager.Instance.Publish(new BaseEvent());
        }
    }

    public class BaseEffect : IEffect
    {
        public void Resolve(IEvent @event)
        {
            MessageBox.Show("Base");
        }
    }

    public class SuperEffect : IEffect
    {
        public void Resolve(IEvent @event)
        {
            MessageBox.Show("Super");
        }
    }


    public class BaseEvent : IEvent
    {

        public Core.Objects.MtgObject Source
        {
            get { throw new NotImplementedException(); }
        }

        public bool Canceled
        {
            get;
            set;
        }

        public IEvent OriginalEvent
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
    public class SuperEvent : BaseEvent
    {

    }
}
