// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_UIText : Table {
  public static FB_UIText GetRootAsFB_UIText(ByteBuffer _bb) { return GetRootAsFB_UIText(_bb, new FB_UIText()); }
  public static FB_UIText GetRootAsFB_UIText(ByteBuffer _bb, FB_UIText obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_UIText __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string Chinese { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public string OldText { get { int o = __offset(8); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Thai { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_UIText> CreateFB_UIText(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset Chinese = default(StringOffset),
      StringOffset OldText = default(StringOffset),
      StringOffset Thai = default(StringOffset)) {
    builder.StartObject(4);
    FB_UIText.AddThai(builder, Thai);
    FB_UIText.AddOldText(builder, OldText);
    FB_UIText.AddChinese(builder, Chinese);
    FB_UIText.AddId(builder, Id);
    return FB_UIText.EndFB_UIText(builder);
  }

  public static void StartFB_UIText(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddChinese(FlatBufferBuilder builder, StringOffset ChineseOffset) { builder.AddOffset(1, ChineseOffset.Value, 0); }
  public static void AddOldText(FlatBufferBuilder builder, StringOffset OldTextOffset) { builder.AddOffset(2, OldTextOffset.Value, 0); }
  public static void AddThai(FlatBufferBuilder builder, StringOffset ThaiOffset) { builder.AddOffset(3, ThaiOffset.Value, 0); }
  public static Offset<FB_UIText> EndFB_UIText(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UIText>(o);
  }
};

public sealed class FB_UITextContainer : Table {
  public static FB_UITextContainer GetRootAsFB_UITextContainer(ByteBuffer _bb) { return GetRootAsFB_UITextContainer(_bb, new FB_UITextContainer()); }
  public static FB_UITextContainer GetRootAsFB_UITextContainer(ByteBuffer _bb, FB_UITextContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_UITextContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_UITextContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_UIText GetItems(int j) { return GetItems(new FB_UIText(), j); }
  public FB_UIText GetItems(FB_UIText obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_UITextContainer> CreateFB_UITextContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_UITextContainer.AddItems(builder, items);
    return FB_UITextContainer.EndFB_UITextContainer(builder);
  }

  public static void StartFB_UITextContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_UIText>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_UITextContainer> EndFB_UITextContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_UITextContainer>(o);
  }
  public static void FinishFB_UITextContainerBuffer(FlatBufferBuilder builder, Offset<FB_UITextContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
