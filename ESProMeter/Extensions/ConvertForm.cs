using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Windows.Forms;

namespace ESProMeter.Extensions
{
    public static class ConvertForm
    {
        public static T TypeOfObject<T>(this Form form, params string[] excepts) where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();
            int index = 0;
            var dict = form.ToDictionary();
            if (excepts.Length > 0)
            {
                foreach (var item in form.FormToDictionary().Keys)
                {
                    if (item != excepts[index]) continue;
                    dict.Remove(excepts[index]);
                    index++;
                }
            }

            foreach (var item in dict)
            {
                foreach (var prop in someObjectType.GetProperties())
                {
                    if (prop.Name.ToLower() != item.Key.ToString().ToLower()) continue;
                    else
                    {
                        if (prop.PropertyType == typeof(System.Int64))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<long>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int32))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<int>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int16))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<Int16>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Byte))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<byte>(), null);
                        }
                        else
                        {
                            prop.SetValue(someObject, item.Value, null);
                        }

                    }
                }

            }
            return someObject;
        }
        public static T TypeOfObject<T>(this Form form) where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();
            foreach (var item in form.ToDictionary())
            {
                foreach (var prop in someObjectType.GetProperties())
                {
                    if (prop.Name.ToLower() != item.Key.ToString().ToLower()) continue;
                    else
                    {
                        if (prop.PropertyType == typeof(System.Int64))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<long>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int32))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<int>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int16))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<Int16>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Byte))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<byte>(), null);
                        }
                        else
                        {
                            prop.SetValue(someObject, item.Value, null);
                        }

                    }
                }

            }
            return someObject;
        }
        public static T AsObject<T>(this Form form) where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();
            foreach (var item in form.FormToDictionary())
            {
                foreach (var prop in someObjectType.GetProperties())
                {
                    if (prop.Name.ToLower() != item.Key.ToLower()) continue;
                    else
                    {
                        if (prop.PropertyType == typeof(System.Int64))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<long>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int32))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<int>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int16))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<Int16>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Byte))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<byte>(), null);
                        }
                        else
                        {
                            prop.SetValue(someObject, item.Value, null);
                        }

                    }
                }

            }
            return someObject;
        }
        public static object AsObject(this Form form)
        {
            dynamic eo = form.FormToDictionary().Aggregate(new ExpandoObject() as IDictionary<string, Object>,
                            (a, p) => { a.Add(p.Key, p.Value); return a; });
            return eo;
        }
        public static object AsObject(this Form form,params Control[] controls)
        {
            dynamic eo = FormToDictionary(controls).Aggregate(new ExpandoObject() as IDictionary<string, Object>,
                            (a, p) => { a.Add(p.Key, p.Value); return a; });
            return eo;
        }
        public static object AsObjectAll(this Form form)
        {
            dynamic eo = form.AsDictionary().Aggregate(new ExpandoObject() as IDictionary<string, Object>,
                            (a, p) => { a.Add(p.Key, p.Value); return a; });
            return eo;
        }
        public static object AsObjectOnly(this Form form, params string[] only)
        {
            var dict = form.AsDictionary(only);
            dynamic eo = dict.Aggregate(new ExpandoObject() as IDictionary<string, object>,
                            (a, p) => { a.Add(p.Key, p.Value); return a; });
            return eo;
        }
        public static object AsObjectOnly(this Form form, params Control[] only)
        {
            var dict = form.AsDictionary(only);
            dynamic eo = dict.Aggregate(new ExpandoObject() as IDictionary<string, object>,
                            (a, p) => { a.Add(p.Key, p.Value); return a; });
            return eo;
        }
        public static object AsObjectExcept(this Form form, params object[] excepts)
        {
            var obj = form.AsDictionary();
            var newDict = new Dictionary<string, object>();
            int index = 0;
            foreach (var item in obj)
            {
                if (item.Key.ToString().ToLower() == excepts[index].ToString().ToLower()) continue;
                newDict.Add(item.Key.ToString(), item.Value);
                index++;
            }
            dynamic eo = newDict.Aggregate(new ExpandoObject() as IDictionary<string, object>,
                            (a, p) => { a.Add(p.Key, p.Value); return a; });
            return eo;
        }
        public static T AsObject<T>(this Form form, params Control[] controls) where T : class, new() 
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();
            foreach (var item in form.FormToDictionary(controls))
            {
                if (someObjectType.GetProperty(item.Key).PropertyType == typeof(System.Int64))
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value.ChangeType<long>(), null);
                }
                else if (someObjectType.GetProperty(item.Key).PropertyType == typeof(System.Int32))
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value.ChangeType<Int32>(), null);
                }
                else if (someObjectType.GetProperty(item.Key).PropertyType == typeof(System.Int16))
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value.ChangeType<Int16>(), null);
                }
                else
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value, null);
                }

            }
            return someObject;
        }
        public static T ToObject<T>(this Form form,params string[] excepts) where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();
            int index = 0;
            var dict = form.FormToDictionary();
            if(excepts.Length > 0)
            {
                foreach (var item in form.FormToDictionary().Keys)
                {
                    if (item != excepts[index]) continue;
                    dict.Remove(excepts[index]);
                    index++;
                }
            }
         
            foreach (var item in dict)
            {
                foreach (var prop in someObjectType.GetProperties())
                {
                    if (prop.Name.ToLower() != item.Key.ToLower()) continue;
                    else
                    {
                        if (prop.PropertyType == typeof(System.Int64))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<long>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int32))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<int>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int16))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<Int16>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Byte))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<byte>(), null);
                        }
                        else
                        {
                            prop.SetValue(someObject, item.Value, null);
                        }

                    }
                }

            }
            return someObject;
        }
        public static T ToObject<T>(this Form form) where T : class,new()
        {
            var someObject=new T();
            var someObjectType=someObject.GetType();
            foreach (var item in form.FormToDictionary())
            {
                foreach (var prop in someObjectType.GetProperties())
                {
                    if (prop.Name.ToLower() != item.Key.ToLower()) continue;
                    else {
                        if (prop.PropertyType == typeof(System.Int64))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<long>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int32))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<int>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Int16))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<Int16>(), null);
                        }
                        else if (prop.PropertyType == typeof(System.Byte))
                        {
                            prop.SetValue(someObject, item.Value.ChangeType<byte>(), null);
                        }
                        else
                        {
                            prop.SetValue(someObject, item.Value, null);
                        }
                       
                    }
                }
               
            }
            return someObject;
        }
        public static T ToObject<T>(this Form form,params Control[] controls) where T : class, new()
        {
            var someObject = new T();
            var someObjectType = someObject.GetType();
            foreach (var item in form.FormToDictionary(controls))
            {
                if (someObjectType.GetProperty(item.Key).PropertyType == typeof(System.Int64))
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value.ChangeType<long>(), null);
                }else if(someObjectType.GetProperty(item.Key).PropertyType == typeof(System.Int32))
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value.ChangeType<Int32>(), null);
                }else if (someObjectType.GetProperty(item.Key).PropertyType == typeof(System.Int16))
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value.ChangeType<Int16>(), null);
                }
                else
                {
                    someObjectType.GetProperty(item.Key)
                             .SetValue(someObject, item.Value, null);
                }
               
            }
            return someObject;
        }
        private static Dictionary<string,object> FormToDictionary(this Form form)
        {
            Dictionary<string,object> result = new Dictionary<string,object>();
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    result.Add(control.Text, ((TextBox)control).Text);
                }
                if (control.GetType() == typeof(Label))
                {
                    result.Add(control.Name, ((Label)control).Text);
                }
                if (control.GetType() == typeof(MaskedTextBox))
                {
                    result.Add(control.Name, ((MaskedTextBox)control).Text);
                }
                if (control.GetType() == typeof(RichTextBox))
                {
                    result.Add(control.Name, ((RichTextBox)control).Text);
                }
                if (control.GetType() == typeof(DateTimePicker))
                {
                    result.Add(control.Name, ((DateTimePicker)control).Value);
                }
                if (control.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)control).SelectedValue==null)
                    {
                        result.Add(control.Name, ((ComboBox)control).Text);
                    }
                    else
                    {
                        result.Add(control.Name, ((ComboBox)control).SelectedValue);
                    }
                }
                if (control.GetType() == typeof(CheckBox))
                {
                    result.Add(control.Name, ((CheckBox)control).Checked);
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    result.Add(control.Name, ((CheckBox)control).Checked);
                }
            }
            return result;
        }
        private static Dictionary<object, object> ToDictionary(this Form form)
        {
            Dictionary<object, object> result = new Dictionary<object, object>();
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    result.Add(control.Tag, ((TextBox)control).Text);
                }
                if (control.GetType() == typeof(Label))
                {
                    result.Add(control.Tag, ((Label)control).Text);
                }
                if (control.GetType() == typeof(MaskedTextBox))
                {
                    result.Add(control.Tag, ((MaskedTextBox)control).Text);
                }
                if (control.GetType() == typeof(RichTextBox))
                {
                    result.Add(control.Tag, ((RichTextBox)control).Text);
                }
                if (control.GetType() == typeof(DateTimePicker))
                {
                    result.Add(control.Tag, ((DateTimePicker)control).Value);
                }
                if (control.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)control).SelectedValue == null)
                    {
                        result.Add(control.Tag, ((ComboBox)control).Text);
                    }
                    else
                    {
                        result.Add(control.Tag, ((ComboBox)control).SelectedValue);
                    }
                }
                if (control.GetType() == typeof(CheckBox))
                {
                    result.Add(control.Tag, ((CheckBox)control).Checked);
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    result.Add(control.Tag, ((CheckBox)control).Checked);
                }
            }
            return result;
        }
        private static Dictionary<string, object> AsDictionary(this Form form)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (((TextBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((TextBox)control).Text);
                }else if (control.GetType() == typeof(Label))
                {
                    if (((Label)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((Label)control).Text);
                }else if (control.GetType() == typeof(MaskedTextBox))
                {
                    if (((MaskedTextBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((MaskedTextBox)control).Text);
                }else if (control.GetType() == typeof(RichTextBox))
                {
                    if (((MaskedTextBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((RichTextBox)control).Text);
                }
                else if (control.GetType() == typeof(DateTimePicker))
                {
                    if (((DateTimePicker)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((DateTimePicker)control).Value);
                }
               else if (control.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)control).Tag == null) continue;
                    if (((ComboBox)control).SelectedValue == null)
                    {
                        result.Add(control.Tag.ToString(), ((ComboBox)control).Text);
                    }
                    else
                    {
                        result.Add(control.Tag.ToString(), ((ComboBox)control).SelectedValue);
                    }
                }
                else if (control.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((CheckBox)control).Checked);
                }
               
                else if (control.GetType() == typeof(RadioButton))
                {
                    if (((RadioButton)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((CheckBox)control).Checked);
                }
                else
                {
                    continue;
                }
            }
            return result;
        }
        private static Dictionary<string, object> AsDictionary(this Form form, params Control[] controls)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (((TextBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((TextBox)control).Text);
                }
                else if (control.GetType() == typeof(Label))
                {
                    if (((Label)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((Label)control).Text);
                }
                else if (control.GetType() == typeof(MaskedTextBox))
                {
                    if (((MaskedTextBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((MaskedTextBox)control).Text);
                }
                else if (control.GetType() == typeof(RichTextBox))
                {
                    if (((RichTextBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((RichTextBox)control).Text);
                }
                else if (control.GetType() == typeof(DateTimePicker))
                {
                    if (((DateTimePicker)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((DateTimePicker)control).Value);
                }
                else if (control.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)control).Tag == null) continue;
                    if (((ComboBox)control).SelectedValue == null)
                    {
                        result.Add(control.Tag.ToString(), ((ComboBox)control).Text);
                    }
                    else
                    {
                        result.Add(control.Tag.ToString(), ((ComboBox)control).SelectedValue);
                    }
                }
                else if (control.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((CheckBox)control).Checked?0:1);
                }
                else if (control.GetType() == typeof(RadioButton))
                {
                    if (((RadioButton)control).Tag == null) continue;
                    result.Add(control.Tag.ToString(), ((RadioButton)control).Checked);
                }
                else
                {
                    continue;
                }

            }
            return result;
        }
        private static Dictionary<string, object> AsDictionary(this Form form, params string[] keys)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            foreach (var item in keys)
            {
                var control = form.Controls.Find(item, true).FirstOrDefault();
                if (control != null)
                {
                    if (control.GetType() == typeof(TextBox))
                    {
                        result.Add(control.Tag.ToString(), ((TextBox)control).Text);
                    }
                    if (control.GetType() == typeof(Label))
                    {
                        result.Add(control.Tag.ToString(), ((Label)control).Text);
                    }
                    if (control.GetType() == typeof(MaskedTextBox))
                    {
                        result.Add(control.Tag.ToString(), ((MaskedTextBox)control).Text);
                    }
                    if (control.GetType() == typeof(RichTextBox))
                    {
                        result.Add(control.Tag.ToString(), ((RichTextBox)control).Text);
                    }
                    if (control.GetType() == typeof(DateTimePicker))
                    {
                        result.Add(control.Tag.ToString(), ((DateTimePicker)control).Value);
                    }
                    if (control.GetType() == typeof(ComboBox))
                    {
                        if (((ComboBox)control).SelectedValue == null)
                        {
                            result.Add(control.Tag.ToString(), ((ComboBox)control).Text);
                        }
                        else
                        {
                            result.Add(control.Tag.ToString(), ((ComboBox)control).SelectedValue);
                        }
                    }
                    if (control.GetType() == typeof(CheckBox))
                    {
                        result.Add(control.Tag.ToString(), ((CheckBox)control).Checked);
                    }
                    if (control.GetType() == typeof(RadioButton))
                    {
                        result.Add(control.Tag.ToString(), ((CheckBox)control).Checked);
                    }
                }
            }
            return result;
        }
        private static Dictionary<string, object> FormToDictionary(this Form form,params Control[] controls)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    result.Add(control.Name, ((TextBox)control).Text);
                }
                if (control.GetType() == typeof(Label))
                {
                    result.Add(control.Name, ((Label)control).Text);
                }
                if (control.GetType() == typeof(MaskedTextBox))
                {
                    result.Add(control.Name, ((MaskedTextBox)control).Text);
                }
                if (control.GetType() == typeof(RichTextBox))
                {
                    result.Add(control.Name, ((RichTextBox)control).Text);
                }
                if (control.GetType() == typeof(DateTimePicker))
                {
                    result.Add(control.Name, ((DateTimePicker)control).Value);
                }
                if (control.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)control).SelectedValue == null)
                    {
                        result.Add(control.Name, ((ComboBox)control).Text);
                    }
                    else
                    {
                        result.Add(control.Name, ((ComboBox)control).SelectedValue);
                    }
                }
                if (control.GetType() == typeof(CheckBox))
                {
                    result.Add(control.Name, ((CheckBox)control).Checked);
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    result.Add(control.Name, ((CheckBox)control).Checked);
                }
               
            }
            return result;
        }
        private static Dictionary<string, object> FormToDictionary(params Control[] controls)
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            foreach (Control control in controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    result.Add(control.Name, ((TextBox)control).Text);
                }
                if (control.GetType() == typeof(Label))
                {
                    result.Add(control.Name, ((Label)control).Text);
                }
                if (control.GetType() == typeof(MaskedTextBox))
                {
                    result.Add(control.Name, ((MaskedTextBox)control).Text);
                }
                if (control.GetType() == typeof(RichTextBox))
                {
                    result.Add(control.Name, ((RichTextBox)control).Text);
                }
                if (control.GetType() == typeof(DateTimePicker))
                {
                    result.Add(control.Name, ((DateTimePicker)control).Value);
                }
                if (control.GetType() == typeof(ComboBox))
                {
                    if (((ComboBox)control).SelectedValue == null)
                    {
                        result.Add(control.Name, ((ComboBox)control).Text);
                    }
                    else
                    {
                        result.Add(control.Name, ((ComboBox)control).SelectedValue);
                    }
                }
                if (control.GetType() == typeof(CheckBox))
                {
                    result.Add(control.Name, ((CheckBox)control).Checked?false:true);
                }
                if (control.GetType() == typeof(RadioButton))
                {
                    result.Add(control.Name, ((CheckBox)control).Checked);
                }

            }
            return result;
        }
        private static T ChangeType<T>(this object value)
        {
            if (value == null)
                return default(T);
            else
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
        }
    }
}
